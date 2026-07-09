using System.ComponentModel.DataAnnotations;

namespace WebAppMVCDotNetC1.Models
{
    public class UserModel
    {
        [Key]  // EmpID is a PK and will be auto incremented    
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
