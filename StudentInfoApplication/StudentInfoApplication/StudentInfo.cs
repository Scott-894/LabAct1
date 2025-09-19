using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNameSpace
{
    public class StudentInfo
    {

        private string stid;
        private string fname;
        private string lname;

        public string StudentId
        {
            get { return stid; }
            set { stid = value; }
        }
        public string FirstName
        { 
        
            get { return fname; }
            set { fname = value; }
        }

        public string LastName
        {
            get { return lname; }
            set { lname = value; }
        }

        public StudentInfo()
        { 
        
        stid = string.Empty;
        fname = string.Empty;
        lname = string.Empty;  

        }

        public StudentInfo(string id, string Fname, string Lname)
        { 
        
        stid = id; 
        fname = Fname;
        lname = Lname;
        }
    }


}
