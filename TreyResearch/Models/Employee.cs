namespace TreyResearch.Models
{
    /// <summary>
    /// sample POCO
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public DateTime Birth { get; set; }
        public bool IsRetirement { get; set; }
    }
}
