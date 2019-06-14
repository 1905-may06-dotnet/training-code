using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IContactRepository
    {
        void Add(ContactUser ContactUser);
        void EditContactUser(ContactUser ContactUser);
        void DeleteContactUser(int Id);
        IEnumerable<ContactUser> GetContactUsers();
        ContactUser GetContactUserByName(string name);
        ContactUser GetContactUserById(int id);
        void Save();
    }
}
