using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Enter company address: ");
            string address = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter fax number: ");
            string faxNumber = Console.ReadLine();
            Console.Write("Web site of the company: ");
            string website = Console.ReadLine();
            Console.Write("Manager first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Manager Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Manager phone: ");
            string managerPhoneNumber = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("{0}\nAddress: {1}\nTel: {2}\nFax: {3}\nWeb Site: {4}\nManager: {5} {6} (age: {7}, tel. {8})", companyName, address,
                phoneNumber, faxNumber, website, firstName, lastName, age, managerPhoneNumber);
        }
    }
}
