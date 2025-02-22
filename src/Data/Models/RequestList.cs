namespace Data.Models
{
    public class RequestList
    {
        public int Id { get; set; }
        public string Department { get; set; } = default!;
        public int Quantity { get; set; }
        public double ProposedTotalSalaryIncrease { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
