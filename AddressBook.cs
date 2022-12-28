﻿using AddressBookDay23;
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
    }
}
