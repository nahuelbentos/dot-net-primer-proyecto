using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormContacts
{
    public class DataAccessLayer
    {
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsContacts;Data Source=DESKTOP-PAV3A72\\SQLSERVER2017");

        public void insertContact( Contact contact)
        {
            try
            {
                conn.Open();
                string query = @"
                                Insert Into Contacts(FirstName, LastName, Phone, Address)
                                VALUES(@FirstName, @LastName, @Phone, @Address)";

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName "@FirstName";

            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
