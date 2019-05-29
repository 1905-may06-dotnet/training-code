using Data.Entities;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactDbContext _db;
        public ContactRepository(ContactDbContext db)
        {
            _db = db;
        }
        public void Add(Domain.Contact contact)
        {
            _db.Contact.Add(Mapper.Map(contact));

        }

        public void DeleteContact(int Id)
        {
            //Kevin's code
            /*var contact = _db.Contact.Where(a => a.Id == Id).FirstOrDefault();
            if(contact)
                _db.Contact.Remove(contact);*/
            //John
            //var element = _db.Contact.Where(a => a.Id == Id).FirstOrDefault();

            //if ( element != null ) _db.Contact.Remove(element);
            //Carlos
            _db.Contact.Remove(_db.Contact.Find(Id));
        }

        public void EditContact(Domain.Contact contact)
        {
            if(_db.Contact.Find(contact.Id) != null)
                _db.Contact.Update(Mapper.Map(contact));
        }

        public Domain.Contact GetContactByName(string name)
        {
            //throw new NotImplementedException();
            var element = _db.Contact.Where(a => a.FirstName.Contains(name) || a.LastName.Contains(name)).FirstOrDefault();

            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }

        public Domain.Contact GetContactById(int id)
        {
            var contact = _db.Contact.Where(x => x.Id == id).FirstOrDefault();
            return Mapper.Map(contact);
        }

        public IEnumerable<Domain.Contact> GetContacts()
        {
            // throw new NotImplementedException();
            //var x = _db.Contact;
            return _db.Contact.Select(x => Mapper.Map(x)); 
        }

        public void Save()
        {
            //throw new NotImplementedException();
            _db.SaveChanges();
        }
    }
}
