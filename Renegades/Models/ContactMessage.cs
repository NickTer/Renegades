using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Renegades.Models
{
    public class ContactMessage
    {
       [Key]
        public int MesId { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        [DisplayName("First Name:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your last name")]
        [DisplayName("Last Name:")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [DisplayName("Email:")]
        public string Email { get; set; }
         [Required(ErrorMessage = "Please enter your Phone number")]
        [DisplayName("Phone:")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter a subject")]
        [DisplayName("Subject:")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Please enter a message")]
        [DisplayName("Message:")]
        public string Message { get; set; }

        public DateTime MessageDate { get; set; }
    }
}