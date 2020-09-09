using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormContacts
{
    public partial class Main : Form
    {
        private BusinessLogicLayer businessLogicLayer;
        public Main()
        {
            InitializeComponent();
            businessLogicLayer = new BusinessLogicLayer();
        }

        #region EVENTS

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.openContactDetailsDialog();
        }

        #endregion

        #region PRIVATE METHODS

        private void openContactDetailsDialog()
        {

            ContactDetails contactDetails = new ContactDetails();
            contactDetails.ShowDialog(this);
        }

        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
            this.populateContacts();
        }

        public void populateContacts()
        {
            List<Contact> contacts = this.businessLogicLayer.getContacts();
            gridContacts.DataSource = contacts;
        }
    }
}
