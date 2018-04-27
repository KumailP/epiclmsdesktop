using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpicLMSDesktopApp
{
    public class User
    {
        public int usertype {get; set;}
        public int dept_id { get; set; }
        public int semester { get; set; }
        public int user_id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public string dept_name { get; set; }

        public User()
        {
        }

        public void setValues(int user_id, int usertype, int dept_id, int semester, string fname, string lname, string email)
        {
            this.usertype = usertype;
            this.dept_id = dept_id;
            this.semester = semester;
            this.user_id = user_id;
            this.fname = fname;
            this.lname = lname;
            this.email = email;
        }
    }
}
