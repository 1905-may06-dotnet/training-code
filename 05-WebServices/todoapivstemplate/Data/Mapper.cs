using Domain;
namespace Data
{
    public static class Mapper
    {
        public static Data.ContactUser Map(Domain.ContactUser dmContactUser)
        {
            Data.ContactUser deContactUser = new ContactUser();
            deContactUser.Id = dmContactUser.Id;
            deContactUser.FirstName = dmContactUser.FirstName;
            deContactUser.MiddleName = dmContactUser.MiddleName;
            deContactUser.LastName = dmContactUser.LastName;
            deContactUser.Mobile = dmContactUser.Mobile;
            deContactUser.WorkPhone = dmContactUser.WorkPhone;
            deContactUser.HomePhone = dmContactUser.HomePhone;
            deContactUser.Email = dmContactUser.Email;
            deContactUser.Created = dmContactUser.Created;
            deContactUser.Modified = dmContactUser.Modified;

            return deContactUser;
        }
        public static Domain.ContactUser Map(Data.ContactUser deContactUser) => new Domain.ContactUser
        {
            Id = deContactUser.Id,
            FirstName = deContactUser.FirstName,
            LastName = deContactUser.LastName,
            MiddleName = deContactUser.MiddleName,
            Mobile = deContactUser.Mobile,
            Email = deContactUser.Email,
            HomePhone = deContactUser.HomePhone,
            WorkPhone = deContactUser.WorkPhone,
            Created = deContactUser.Created,
            Modified = deContactUser.Modified
        };
    }
}