using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AddressBookUsingLINQAndDataTable
{
    public class AddressBookDataTable
    {
        /// <summary>
        /// Method to Create AddressBook DataTable
        /// </summary>
        public DataTable CreateAddressBookDataTable()
        {
            DataTable addressBookTable = new DataTable();

            //Add Columns to DataTable
            addressBookTable.Columns.Add("FirstName", typeof(string));
            addressBookTable.Columns.Add("LastName", typeof(string));
            addressBookTable.Columns.Add("Address", typeof(string));
            addressBookTable.Columns.Add("City", typeof(string));
            addressBookTable.Columns.Add("State", typeof(string));
            addressBookTable.Columns.Add("Zip", typeof(int));
            addressBookTable.Columns.Add("PhoneNumber", typeof(long));
            addressBookTable.Columns.Add("Email", typeof(string));
            addressBookTable.Columns.Add("AddressBookType", typeof(string));
            addressBookTable.Columns.Add("AddressBookName", typeof(string));

            //Add Values for Columns
            addressBookTable.Rows.Add("Arti", "Dandge", "Ashish Plaza", "Pune", "MH", 763222, 9876543210, "asd@gmail.com", "Friends", "AddressBook1");
            addressBookTable.Rows.Add("Rohit", "Magar", "Venu Hights", "Pune", "MH", 763222, 933343210, "rohit@gmail.com", "Friends", "AddressBook1");
            addressBookTable.Rows.Add("Neha", "Sharma", "Flex Road", "Mumbai", "MH", 403222, 6776543210, "neha@gmail.com", "Family", "AddressBook2");
            addressBookTable.Rows.Add("Preeti", "Neghi", "Neer Road", "Banglore", "Karnataka", 40002, 999000880, "preeti@gmail.com", "Friends", "AddressBook1");
            addressBookTable.Rows.Add("Prakash", "Swami", "Panji", "Panaji", "Goa", 43254, 7777743210, "asd@gmail.com", "Friends", "AddressBook1");
            addressBookTable.Rows.Add("Rama", "Magare", "Indor", "Indor", "MP", 43254, 7877743990, "Rama@gmail.com", "Family", "AddressBook2");
            addressBookTable.Rows.Add("Rekha", "Swami", "baroda", "Baroda", "MP", 43254, 7888743210, "rekha@gmail.com", "Professional", "AddressBook3");
            addressBookTable.Rows.Add("Pratiksha", "Swami", "baroda", "Baroda", "MP", 43254, 7888743210, "rekha@gmail.com", "Friends", "AddressBook1");
            addressBookTable.Rows.Add("Diksha", "Swami", "baroda", "Baroda", "MP", 43254, 7888743210, "rekha@gmail.com", "Friends", "AddressBook1");

            //Return AddressBook DataTable
            return addressBookTable;
        }

        /// <summary>
        /// Method to Update Contact and Display Updated Contact 
        /// </summary>
        /// <param name="table"></param>
        public void EditContact(DataTable table)
        {
            var contacts = table.AsEnumerable().Where(x => x.Field<string>("FirstName") == "Arti");
            foreach(var contact in contacts)
            {
                contact.SetField("LastName", "Dudhe");
                contact.SetField("City", "Banglore");
                contact.SetField("State", "Karnataka");
                contact.SetField("Email","artid12@yahoo.com");
            }
            Console.WriteLine("\n**************************************************");
            Console.WriteLine("Following is recently Updated Contact");
            DisplayContacts(contacts.CopyToDataTable());
        }
        
        /// <summary>
        /// Method To Remove Contact from datatable and display remaining Contacts
        /// </summary>
        /// <param name="table"></param>
        public void DeleteContact(DataTable table)
        {
            var contacts = table.AsEnumerable().Where(r => r.Field<string>("FirstName") != "Pratiksha").CopyToDataTable();
            Console.WriteLine("Following Contacts are present in Datatable after deletion of Contact of Person 'Pratiksha' ");
            DisplayContacts(contacts);
        }

        /// <summary>
        /// Method to Retrieve Contact beloning to Perticular City or State
        /// </summary>
        /// <param name="table"></param>
        public void RetrieveContactBelonginhToPerticularCityORState(DataTable table)
        {
            var contacts = table.Rows.Cast<DataRow>()
                             .Where(x => x["City"].Equals("Pune") ||  x["State"].Equals("MH")).CopyToDataTable();
            Console.WriteLine("Following Contacts belonging to perticular City or State ");
            DisplayContacts(contacts);
        }

        /// <summary>
        /// Method to Retrieve Count of Contacts beloning to Perticular City and State
        /// </summary>
        /// <param name="table"></param>
        public void CountContactsFromPerticularCityANDState(DataTable table)
        {
            var contacts = table.Rows.Cast<DataRow>()
                             .Where(x => x["City"].Equals("Baroda") && x["State"].Equals("MP")).Count();
            Console.WriteLine("Count of Persons Beloning to City 'Baroda' and State 'MP' : {0} ", contacts);
        }

        /// <summary>
        /// Method to Sort Contact using peron's first name
        /// </summary>
        /// <param name="table"></param>
        public void SortContacts(DataTable table)
        {
            var contacts = table.Rows.Cast<DataRow>()
                           .OrderBy(x => x.Field<string>("FirstName"));
            Console.WriteLine("\n**************************************************");
            Console.WriteLine("\nSorted Contacts using Person's first name");
            DisplayContacts(contacts.CopyToDataTable());
        }

        /// <summary>
        /// Method to display contacts from Address Book DataTable
        /// </summary>
        /// <param name="table"></param>
        public void DisplayContacts(DataTable table)
        {
            var contacts = table.Rows.Cast<DataRow>();
            foreach (var contact in contacts)
            {
                Console.WriteLine("\n------------------------------------");
                Console.Write("\nFirst Name : "+contact.Field<string>("FirstName") +" "+ "\nLast Name : " + contact.Field<string>("LastName") +" "+ "\nAddress : "+contact.Field<string>("Address") + " " + "\nCity : "+contact.Field<string>("City") + " " + "\nState : "+ contact.Field<string>("State") 
                    + " " + "\nZip : "+contact.Field<int>("Zip") + " " + "\nPhone Number : "+contact.Field<long>("PhoneNumber") + " " + "\nEmail : " + contact.Field<string>("Email") + " ");
                Console.WriteLine("\n------------------------------------");
            }
            Console.WriteLine("\n**************************************************");
        }
    }
}
