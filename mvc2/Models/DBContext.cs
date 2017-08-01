using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvc2.Models
{
    public class DBContext: DbContext
    {
        public DBContext() : base("DevDBContextnew")
        {
        }
        public DbSet<login> login2 { get; set; }
        public DbSet<Registration> registration { get; set; }

    }
}