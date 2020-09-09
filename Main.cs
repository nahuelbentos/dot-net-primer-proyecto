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
        public Main()
        {
            InitializeComponent();
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
            contactDetails.ShowDialog();
        }

        #endregion

    }
}
