using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceOOP
{
    public abstract class Student
    {
        internal string firstName = string.Empty;
        internal string lastName = string.Empty;
        internal string address = string.Empty;
        internal string contact = string.Empty;
        internal DateTime joinDate;

        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract string Address { get; set; }
        public abstract string Contact { get; set; }
        public abstract DateTime JoinDate { get; set; }
        public abstract string GetFullName();
        public abstract string GetAddress();
        public abstract string GetContact();
        public abstract string GetDuration();
    }
}
