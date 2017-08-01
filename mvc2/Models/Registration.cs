using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc2.Models
{
    public class Registration
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="you have to enter usename")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="you have to enter the password")]
        public string Password { get; set; }
        public string Address { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}