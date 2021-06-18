using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("INPUTS\n=========================");

                Console.Write("\nEnter ID: ");
                string id = Console.ReadLine();

                Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                string lasttName = Console.ReadLine();

                Console.Write("Enter Address: ");
                string address = Console.ReadLine();

                Console.Write("Enter Email: ");
                string contact = Console.ReadLine();

                Console.Write("Enter Joining Date (mm/dd/yyyy): ");
                DateTime JoinDate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Enter End Date (mm/dd/yyyy): ");
                DateTime EndDate = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("\nDESIGNATIONS:\n=========================\n1. Chairman\n2. Professor\n3. AssociateProfessor\n4. Lecturer\n5. JuniorLecturer\n6. SeniorLecturer\n7. Coordinator");
                Console.Write("\nInput any one serial number of the designations given above: ");
                int desigCode = Int32.Parse(Console.ReadLine());

                Teacher obj = new Teacher(id, firstName, lasttName, address, contact, JoinDate, EndDate, desigCode);
                Console.Write("\nGive roles of the employee (Seperate by comma[,]): ");
                string[] roles = obj.GetRole(Console.ReadLine());

                Console.WriteLine("\n\nOUTPUTS\n=========================");
                Console.WriteLine("\nTeacher ID   : " + obj.ID 
                    + "\nTeacher Name : " + obj.GetFullName() 
                    + "\nAddress      : " + obj.GetAddress()
                    + "\nEmail        : " + obj.GetContact()
                    + "\nStart Date   : " + obj.JoinDate.ToShortDateString() 
                    + "\nEnd Date     : " + obj.EndDate.ToShortDateString() 
                    + "\nDesignation  : " + obj.Designation 
                    + "\nDuration     : " + obj.GetDuration() 
                    + "\n\nRole plays :\n=========================");

                for (int i = 0; i < roles.Length; i++)
                {
                    Console.WriteLine((i + 1).ToString() + ". " + roles[i].Trim());
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

