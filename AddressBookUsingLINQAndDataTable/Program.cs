using System;
using System.Data;
namespace AddressBookUsingLINQAndDataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System using Linq and DataTable");
            AddressBookDataTable addressBookDataTable = new AddressBookDataTable();
            DataTable table = addressBookDataTable.CreateAddressBookDataTable();
            addressBookDataTable.DisplayContacts(table);
            addressBookDataTable.EditContact(table);
            addressBookDataTable.DeleteContact(table);
            addressBookDataTable.RetrieveContactBelonginhToPerticularCityORState(table);
            addressBookDataTable.CountContactsFromPerticularCityANDState(table);
            addressBookDataTable.SortContacts(table);
        }
    }
}
