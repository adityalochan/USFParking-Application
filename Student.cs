using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USFParking
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public string userID;
        public string password;
        public string category;

        public Student(string f, string l, string u, string p, string c)
        {
            firstName = f;
            lastName = l;
            userID = u;
            password = p;
            category = c;
        }

        public bool isStudent(string u, string p)
        {
            return userID == u && password == p;
        }
    }
}
