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
    public partial class ContactDetails : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        public ContactDetails()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.saveContact();
            this.Close();
            ((Main)this.Owner).populateContacts();
        }

        private void saveContact()
        {

            Contact contact = new Contact();
            contact.FirstName = textFirstName.Text;
            contact.LastName = textLastName.Text;
            contact.Phone = textPhone.Text;
            contact.Address = textAddress.Text;


            this._businessLogicLayer.saveContact(contact);
        }
    }
}
