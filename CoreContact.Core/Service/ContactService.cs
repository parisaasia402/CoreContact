using CoreContact.Core.Service.Interface;
using CoreContact.DataLayer.Context;
using CoreContact.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreContact.Core.Service
{
    public class ContactService : IContactService
    {
        private ContactContext _context;
        public ContactService(ContactContext context)
        {
            _context = context;
        }
        public int AddContact(Contact contact)
        {
            try
            {
                _context.contacts.Add(contact);
                _context.SaveChanges();
                return contact.ID;
            }
            catch (Exception)
            {

                return 0;
            }
            /*throw new NotImplementedException();*/
        }

        public bool DeleteContact(Contact contact)
        {
            try
            {
                _context.contacts.Remove(contact);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Contact FindContactByID(int id)
        {
            return _context.contacts.Find(id);
            
        }

        public List<Contact> ShowAllContact()
        {
            return _context.contacts.ToList();
            
        }

        public bool UpdateContact(Contact contact)
        {
            try
            {
                _context.contacts.Update(contact);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            /*throw new NotImplementedException();*/
        }
    }
}
