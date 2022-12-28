using AddressBookProgram;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDay23
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address BOOK Program");
            AddressBook Add = new AddressBook("Rajpal", "Singh", "Ramesh Nagar", "Delhi", "New Delhi", "rajpalsinghrawat229@gamil.com", 110015, 9050545979);
                Add.DisplayContact();
        }
    }
}