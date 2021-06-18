using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceOOP
{
    public sealed class Teacher : Student, IRole
    {
        public string ID { get; set; }
        public override string FirstName { get => firstName; set => firstName = value; }
        public override string LastName { get => lastName; set => lastName = value; }
        public override string Address { get => address; set => address = value; }
        public override string Contact { get => contact; set => contact = value; }
        public override DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public DateTime EndDate { get; set; }
        public string Designation { get; set; }

        public Teacher(string id, string firstName, string lastName, string address, string contact, DateTime joinDate, DateTime endDate, int desig)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Contact = contact;
            this.JoinDate = joinDate;
            this.EndDate = endDate;
            this.Designation = Enum.GetName(typeof(Designation), desig);
        }

        public override string GetDuration()
        {
            TimeSpan duration = DateTime.Now - JoinDate;
            int years = duration.Days / 365;
            return years.ToString() + " years ";
        }

        public override string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public override string GetAddress()
        {
            return Address;
        }
        public override string GetContact()
        {
            return Contact;
        }

        public string[] GetRole(string role)
        {
            string[] roles = role.Split(',');
            return roles;
        }
    }
}
