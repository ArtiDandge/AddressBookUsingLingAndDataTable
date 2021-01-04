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
        public void CreateAddressBookDataTable()
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
        }
    }
}
