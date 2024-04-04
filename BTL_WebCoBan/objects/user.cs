using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WebCoBan.objects
{
    public class user
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public user() { }

        public user(string firstName, string lastName, string userName, string email, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.email = email;
            this.password = password;
        }
    }
}