using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Sample.Repositary.Model
{
    public enum PersonProfile
    {
        Innovative,
        Mentor,
        Investor,
        Entrepreneur
    }

    public class Person : ModelBase
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        /// <summary>
        /// Person's first name
        /// </summary>
        [DisplayName("First name")]
        [Required(ErrorMessage = "First name is required!")]
        [StringLength(100)]
        public string FirstName { get; set; }

        /// <summary>
        /// Person's last name
        /// </summary>
        [DisplayName("Last name")]
        [Required(ErrorMessage = "Last name required!")]
        [StringLength(100)]
        public string LastName { get; set; }

        /// <summary>
        /// Person's role
        /// </summary>
        [DisplayName("Role")]
        [Required(ErrorMessage = "Role is required!")]
        [StringLength(255)]
        public string Role { get; set; }

        /// <summary>
        /// Company name
        /// </summary>
        [DisplayName("Company")]
        [StringLength(255)]
        public string Company { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        [DisplayName("Phone number")]
        [Required(ErrorMessage = "Phone number is required")]
        [StringLength(13)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        [DisplayName("Gender (optional)")]
        public char? Gender { get; set; }

        /// <summary>
        /// Birth date
        /// </summary>
        [DisplayName("Date of birth")]
        [Required(ErrorMessage = "Date of birth is required!")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Profile.
        /// </summary>
        [DisplayName("Profile")]
        [Required(ErrorMessage = "Profile is required")]
        public PersonProfile Profile { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
