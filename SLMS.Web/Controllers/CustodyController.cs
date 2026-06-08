using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SLMS.Web.Data;
using SLMS.Web.Models;
using SLMS.Models.Entities;

namespace SLMS.Controllers
{
    public class CustodyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustodyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Transfer Page
        public async Task<IActionResult> Transfer()
        {
            ViewBag.Books = await _context.Books
                .OrderBy(b => b.Title)
                .ToListAsync();

            return View();
        }

        // POST: Transfer Custody
        [HttpPost]
        public async Task<IActionResult> Transfer(TransferCustodyViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Books = await _context.Books.ToListAsync();
                return View(model);
            }

            var book = await _context.Books
                .FirstOrDefaultAsync(b => b.BookId == model.BookId);

            if (book == null)
            {
                return NotFound();
            }

            string oldCustody = book.CurrentCustody;

            // Update current custody
            book.CurrentCustody = model.ToDepartment;

            // Save custody history
            var history = new CustodyHistory
            {
                BookId = book.BookId,
                FromDepartment = oldCustody,
                ToDepartment = model.ToDepartment,
                TransferDate = DateTime.UtcNow,
                Remarks = model.Remarks
            };

            _context.CustodyHistories.Add(history);

            // Save audit log
            var audit = new AuditLog
            {
                Action = "Custody Transfer",
                EntityName = "Book",
                Description = $"Book '{book.Title}' transferred from {oldCustody} to {model.ToDepartment}",
                CreatedAt = DateTime.UtcNow
            };

            _context.AuditLogs.Add(audit);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(History));
        }

        // Custody History
        public async Task<IActionResult> History()
        {
            var histories = await _context.CustodyHistories
                .Include(h => h.Book)
                .OrderByDescending(h => h.TransferDate)
                .ToListAsync();

            return View(histories);
        }

        // Audit History
        public async Task<IActionResult> AuditHistory()
        {
            var logs = await _context.AuditLogs
                .OrderByDescending(a => a.CreatedAt)
                .ToListAsync();

            return View(logs);
        }
    }
}