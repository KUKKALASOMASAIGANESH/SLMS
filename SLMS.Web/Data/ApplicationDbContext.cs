using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SLMS.Models.Entities;

namespace SLMS.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<BookIssue> BookIssues { get; set; }
        public DbSet<BookReturn> BookReturns { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<CustodyHistory> CustodyHistories { get; set; }
        public DbSet<DigitalContent> DigitalContents { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Department>()
                .HasIndex(d => d.DepartmentCode)
                .IsUnique();

            builder.Entity<Category>()
                .HasIndex(c => c.CategoryName)
                .IsUnique();

            builder.Entity<Book>()
                .HasOne(b => b.Category)
                .WithMany()
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Book>()
                .HasOne(b => b.Vendor)
                .WithMany()
                .HasForeignKey(b => b.VendorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}