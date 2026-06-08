namespace SLMS.Models.Entities;

public class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeCode { get; set; } = string.Empty;

    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public int DepartmentId { get; set; }

    public Department? Department { get; set; }

    public string Designation { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;
}