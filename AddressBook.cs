
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressBook
    {
        public string FirstName, LastName, Address, City, State, Email;
        public int Zip;
        public long PhoneNumber;
        public AddressBook[] ContactArray;
        public int Contact = 0;
        public AddressBook()
        {
            this.ContactArray = new AddressBook[5];
        }
        public AddressBook(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Email = email;
            Zip = zip;
            PhoneNumber = phoneNumber;
        }
        public void CreateContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNum)
        {
            ContactArray[this.Contact] = new AddressBook(firstName, lastName, address, city, state, email, zip, phoneNum);
            Contact++;
            Program program = new Program();
            program.DisplayContacts(ContactArray, Contact);
        }
        public void EditContact()
        {
            int i = 0;
            Console.WriteLine("Enter First Name to Edit");
            string FirstName = Console.ReadLine();
            while (ContactArray[i].FirstName != FirstName)
            {
                i++;
            }
            Console.WriteLine("Enter Field To Be Modify\n1.FirstNmae\n2.LastName\n3.Address\n4.City\n5.State\n6.Zip\n7.Email\n8.PhoneNumber");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the Modifed Value");
                    string FName = Console.ReadLine();
                    ContactArray[i].FirstName = FName;
                    break;
                case 2:
                    Console.WriteLine("Enter the Modifed Value");
                    string LName = Console.ReadLine();
                    ContactArray[i].LastName = LName;
                    break;
                case 3:
                    Console.WriteLine("Enter the Modifed Value");
                    string Add = Console.ReadLine();
                    ContactArray[i].Address = Add;
                    break;
                case 4:
                    Console.WriteLine("Enter the Modifed Value");
                    string city = Console.ReadLine();
                    ContactArray[i].City = city;
                    break;
                case 5:
                    Console.WriteLine("Enter the Modifed Value");
                    string StateN = Console.ReadLine();
                    ContactArray[i].State = StateN;
                    break;
                case 6:
                    Console.WriteLine("Enter the Modifed Value");
                    int ZipN = Convert.ToInt32(Console.ReadLine());
                    ContactArray[i].Zip = ZipN;
                    break;
                case 7:
                    Console.WriteLine("Enter the Modifed Value");
                    string MailID = Console.ReadLine();
                    ContactArray[i].Email = MailID;
                    break;
                case 8:
                    Console.WriteLine("Enter the Modifed Value");
                    long PhnNum = Convert.ToInt64(Console.ReadLine());
                    ContactArray[i].PhoneNumber = PhnNum;
                    break;
            }
            Program program = new Program();
            program.DisplayContacts(ContactArray, Contact);
        }

        public void DeleteContact()
        {
            Console.WriteLine("Enter the first name of the contact to delete:");
            string firstName = Console.ReadLine();

            int index = -1;
            for (int i = 0; i < Contact; i++)
            {
                if (ContactArray[i].FirstName == firstName)
                {
                    index = i;
                    break;
                }

            }
            if (index != -1)
            {
                for (int i = index; i < Contact - 1; i++)
                {
                    ContactArray[i] = ContactArray[i + 1];
                }
                Contact--;
                Console.WriteLine("Contact is Deleted\n");
            }
            else
            {
                Console.WriteLine("No contact with this first name\n");
            }
            Program program = new Program();
            program.DisplayContacts(ContactArray, Contact);
        }
    }
}