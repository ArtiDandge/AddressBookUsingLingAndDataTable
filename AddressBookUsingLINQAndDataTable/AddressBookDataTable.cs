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

            //Add Values for Columns
            addressBookTable.Rows.Add("Arti", "Dandge", "Ashish Plaza", "Pune", "MH", 763222, 9876543210, "asd@gmail.com");
            addressBookTable.Rows.Add("Rohit", "Magar", "Venu Hights", "Pune", "MH", 763222, 933343210, "rohit@gmail.com");
            addressBookTable.Rows.Add("Neha", "Sharma", "Flex Road", "Mumbai", "MH", 403222, 6776543210, "neha@gmail.com");
            addressBookTable.Rows.Add("Preeti", "Neghi", "Neer Road", "Benglore", "Karnataka", 40002, 999000880, "preeti@gmail.com");
            addressBookTable.Rows.Add("Prakash", "Swami", "Panji", "Panaji", "Goa", 43254, 7777743210, "asd@gmail.com");
            addressBookTable.Rows.Add("Rama", "Magare", "Indor", "Indor", "MP", 43254, 7877743990, "Rama@gmail.com");
            addressBookTable.Rows.Add("Rekha", "Swami", "baroda", "Baroda", "MP", 43254, 7888743210, "rekha@gmail.com");

            //Return AddressBook DataTable
            return addressBookTable;
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
        }
    }
}
