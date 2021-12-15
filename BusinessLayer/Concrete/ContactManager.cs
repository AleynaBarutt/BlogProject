using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactdal;
       

        public ContactManager(IContactDal contactdal)
        {
            _contactdal = contactdal;
        }

        public void ContactAdd(Contacts contact)
        {
            _contactdal.Insert(contact);
        }
    }
}
