namespace Data.Models
{
    public class ProposedEmployee
    {
        public string EmployeeId { get; set; } = default!;
        public string FullName { get; set; } = default!;
        public string Department { get; set; } = default!;
        public double OldSalary { get; set; }
        public double NewSalary { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; }
        
        public ProposedEmployee()
        {
        }

        public ProposedEmployee(ProposedEmployee pe)
        {
            EmployeeId = pe.EmployeeId;
            FullName = pe.FullName;
            Department = pe.Department;
            OldSalary = pe.OldSalary;
            NewSalary = pe.NewSalary;
            CreatedDate = pe.CreatedDate;
            UpdatedDate = pe.UpdatedDate;
        }
        
        public ProposedEmployee Clone()
        {
            return new ProposedEmployee
            {
                EmployeeId  = this.EmployeeId,
                FullName    = this.FullName,
                Department  = this.Department,
                OldSalary   = this.OldSalary,
                NewSalary   = this.NewSalary,
                CreatedDate = this.CreatedDate,
                UpdatedDate = this.UpdatedDate
            };
        }
    }
}
