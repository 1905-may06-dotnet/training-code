using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactContext _db;
        public ContactRepository(ContactContext db)
        {
            _db = db;
        }
        public void Add(Domain.ContactUser ContactUser)
        {
            _db.ContactUser.Add(Mapper.Map(ContactUser));
        }

        public void DeleteContactUser(int Id)
        {
            _db.ContactUser.Remove(_db.ContactUser.Find(Id));
        }

        public void EditContactUser(Domain.ContactUser ContactUser)
        {
            if (_db.ContactUser.Find(ContactUser.Id) != null)
                _db.ContactUser.Update(Mapper.Map(ContactUser));
        }

        public Domain.ContactUser GetContactUserByName(string name)
        {
            var element = _db.ContactUser.Where(a => a.FirstName.Contains(name) || a.LastName.Contains(name)).FirstOrDefault();

            if (element != null)
                return Mapper.Map(element);
            else
                return null;
        }

        public Domain.ContactUser GetContactUserById(int id)
        {
            var ContactUser = _db.ContactUser.Where(x => x.Id == id).FirstOrDefault();
            return Mapper.Map(ContactUser);
        }

        public IEnumerable<Domain.ContactUser> GetContactUsers()
        {
            return _db.ContactUser.Select(x => Mapper.Map(x));
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
