using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Data
{
    public static class Mapper
    {
        public static Data.Entities.Contact Map(Domain.Contact dmContact)
        {
            Data.Entities.Contact deContact = new Entities.Contact();
            deContact.Id = dmContact.Id;
            deContact.FirstName = dmContact.FirstName;
            deContact.MiddleName = dmContact.MiddleName;
            deContact.LastName= dmContact.LastName;
            deContact.Mobile = dmContact.Mobile;
            deContact.WorkPhone= dmContact.WorkPhone;
            deContact.HomePhone= dmContact.HomePhone;
            deContact.Email = dmContact.Email;
            deContact.Created = dmContact.Created;
            deContact.Modified = dmContact.Modified;

          return deContact;
        }
        public static Domain.Contact Map(Data.Entities.Contact deContact) => new Domain.Contact
        {
            Id = deContact.Id,
            FirstName = deContact.FirstName,
            LastName = deContact.LastName,
            MiddleName = deContact.MiddleName,
            Mobile = deContact.Mobile,
            Email = deContact.Email,
            HomePhone = deContact.HomePhone,
            WorkPhone = deContact.WorkPhone,
            Created = deContact.Created,
            Modified = deContact.Modified
        };
    }
}
