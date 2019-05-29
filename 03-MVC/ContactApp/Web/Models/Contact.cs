using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Contact
    {
        //Data Annotations - UI Appearance of fields could be manipulate
        //- You can use them to validate the input data
        //[Required]
        //[Range]
        //[Max]
        //[Min]
        //[Compare]
        //[RegularExpression()]

        //- With EF Code First you can manage the types of the entities
        [DisplayName("#")]
        public int Num { get; set; } = 0;
        [DisplayName("Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="First Name cannot be blank")]
        [StringLength(30,ErrorMessage ="Name should be maximun 30 characters")]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required(ErrorMessage ="Last Name cannot be blank")]
        public string LastName { get; set; }
        [DisplayName("Phone")]
        [Required(ErrorMessage ="Phone is mandatory")]
        public string  Mobile { get; set; }
        [DisplayName("Work Phone")]
        public string  WorkPhone { get; set; }
        [DisplayName("Home Phone")]
        public string HomePhone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get;     set; }
        public int Id { get; set; }

    }
}
