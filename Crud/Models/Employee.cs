using System.ComponentModel.DataAnnotations;

namespace Crud.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public decimal salary { get; set; }
        public string role { get; set; }
        public string email { get; set; }
    }
}
