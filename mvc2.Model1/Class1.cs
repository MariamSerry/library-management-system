using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc2.Model1
{
    public class DBContext : DbContext
    {
        public DBContext() : base("DevDBContextnew")
        {
        }
        public DbSet<login> login2 { get; set; }
        public DbSet<Registration> registration { get; set; }

    }
    public class login
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class Registration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required(ErrorMessage = "you have to enter usename")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "you have to enter the password")]
        public string Password { get; set; }
        public string Address { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
