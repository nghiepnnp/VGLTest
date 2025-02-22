using Data.Models;

namespace Data
{
    public class Repository
    {
        public static List<RequestList> RequestList = [];
        public static List<ProposedEmployee> ProposedEmployeeList = [];
        public static List<Employee> EmployeeList = [];

        public Repository()
        {
            Initialize();
        }

        public static void Initialize()
        {
            EmployeeList = new()
            {
                new() {Id = "000001", FullName = "Nguyễn Văn A", Department = "ITC", Birthday = DateTime.Now.AddYears(-39), Gender = "Nam", Salary = 4900000 },
                new() {Id = "000002", FullName = "Trần Thị B", Department = "ITC", Birthday = DateTime.Now.AddYears(-39), Gender = "Nữ", Salary = 4800000 },
                new() {Id = "000003", FullName = "Nguyễn Văn C", Department = "ITC", Birthday = DateTime.Now.AddYears(-39), Gender = "Nam", Salary = 4700000 },
                new() {Id = "000004", FullName = "Nguyễn Văn D", Department = "ITC", Birthday = DateTime.Now.AddYears(-39), Gender = "Nam", Salary = 4600000 },
                new() {Id = "000005", FullName = "Nguyễn Văn E", Department = "ITC", Birthday = DateTime.Now.AddYears(-39), Gender = "Nam", Salary = 4750000 },
                new() {Id = "000006", FullName = "Nguyễn Văn F", Department = "ITC", Birthday = DateTime.Now.AddYears(-39), Gender = "Nam", Salary = 4650000 },
                new() {Id = "000006", FullName = "Trần Thị G", Department = "ITC", Birthday = DateTime.Now.AddYears(-39), Gender = "Nữ", Salary = 4950000 }
            };

            ProposedEmployeeList = EmployeeList.Select(e => new ProposedEmployee
            {
                EmployeeId = e.Id,
                FullName = e.FullName,
                Department = e.Department,
                OldSalary = e.Salary,
                NewSalary = e.Salary * 1.15,
                CreatedDate = DateTime.Now
            })
            .OrderBy(x => Guid.NewGuid())
            .Take(2)
            .ToList();

            RequestList = new()
            {
                new() { Id = 11077, Department = "ITC", Quantity = ProposedEmployeeList.Count, ProposedTotalSalaryIncrease = ProposedEmployeeList.Sum(e => e.NewSalary - e.OldSalary)},
            };
        }
    }
}
