
using System.ComponentModel.DataAnnotations;

namespace WebAppMVCDotNetC1.Models
{
    public class EmpModel
    {
        [Key]  // EmpID is a PK and will be auto incremented    
        public int EmpID { get; set; }
        public string EName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Dob { get; set; }
    }
}
