using mvc2.Model1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc2.core
{
    public class Userserver
    {
        DBContext db = new DBContext();

        public bool Check(string username , string password )
        {
            DBContext db = new DBContext();
            Registration existUser = db.registration.FirstOrDefault(a => a.Password== password && a.UserName == username);
                if (existUser != null)
                {
                return true;
                }
                else
                {
                return false;
                }
            }

        

        public void Add(Registration newRegisrtation)
        {
            DBContext db = new DBContext();
            db.registration.Add(newRegisrtation);
            db.SaveChanges();
        }
    }
    }
