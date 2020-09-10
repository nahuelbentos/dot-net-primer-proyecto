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

        public void populateContacts(string filter = null)
        {
            List<Contact> contacts = this.businessLogicLayer.getContacts(filter);
            gridContacts.DataSource = contacts;
        }

        private void gridContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell) gridContacts.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Edit")
            {
                ContactDetails contactDetails = new ContactDetails();
                contactDetails.loadContact(new Contact
                {
                    Id          =  int.Parse( (gridContacts.Rows[e.RowIndex].Cells[0]).Value.ToString() ),
                    FirstName   = gridContacts.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    LastName    = gridContacts.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Phone       = gridContacts.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Address     = gridContacts.Rows[e.RowIndex].Cells[4].Value.ToString(),
                });

                contactDetails.ShowDialog(this);
            } else if(cell.Value.ToString() == "Delete")
            {
                int Id = int.Parse((gridContacts.Rows[e.RowIndex].Cells[0]).Value.ToString());
                this.deleteContact(Id);
            }
        }

        private void deleteContact(int id)
        {
            businessLogicLayer.deleteContact(id);
            this.populateContacts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.populateContacts(txtSearch.Text);
            txtSearch.Clear();
        }
    }
}
