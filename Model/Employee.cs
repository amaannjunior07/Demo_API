using System.ComponentModel.DataAnnotations;


namespace Demo_API.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; } //nullable property
        public string? Designation { get; set; }
        public double Salary { get; set; }
        [DataType(DataType.Date)]
        public DateTime? JoinDate { get; set; }
        
    }
}
//Data Source = (localdb)\ProjectModels; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover=False