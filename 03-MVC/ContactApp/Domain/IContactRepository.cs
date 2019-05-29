using System;
using System.Collections.Generic;

namespace Domain
{
    public interface IContactRepository
    {
        void Add(Contact contact);
        void EditContact(Contact contact);
        void DeleteContact(int Id);
        IEnumerable<Contact> GetContacts();
        Contact GetContactByName(string name);
        void Save();
    }
}
