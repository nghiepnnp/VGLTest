namespace Data.Models
{
    public class Employee
    {
        public string Id { get; set; } = default!;
        public string FullName { get; set; } = default!;
        public string Department { get; set; } = default!;
        public double Salary { get; set; }
        public string Gender { get; set; } = default!;
        public DateTime Birthday { get; set; } = default!;

        public Employee()
        {
        }

        public Employee(Employee e)
        {
            Id = e.Id;
            FullName = e.FullName;
            Department = e.Department;
            Salary = e.Salary;
            Gender = e.Gender;
            Birthday = e.Birthday;
        }        
    }
}