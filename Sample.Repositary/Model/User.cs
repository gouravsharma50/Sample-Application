using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Repositary.Model
{
    public partial class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Company { get; set; }
        public string PhoneNumber { get; set; }
        public char? Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsActive { get; set; }
        public string Password { get; set; }

    }
}
