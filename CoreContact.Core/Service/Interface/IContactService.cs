using CoreContact.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CoreContact.Core.Service.Interface
{
    public interface IContactService
    {
        List<Contact> ShowAllContact();
        Contact FindContactByID(int id);
        int AddContact(Contact contact);
        bool UpdateContact(Contact contact);
        bool DeleteContact(Contact contact);
    }
}
