using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormContacts
{
    public class BusinessLogicLayer
    {
        private DataAccessLayer _dataAccessLayer;

        public BusinessLogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }
        public Contact saveContact( Contact contact)
        {
            if ( contact.Id == 0)
            {
                _dataAccessLayer.insertContact(contact);
            } else
            {
               // _dataAccessLayer.updateContact(contact);
            }

            return null;
        }

    }
}
