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
        //- With EF Code First you can manage the types of the entities
        [DisplayName("#")]
        public int Num { get; set; } = 0;
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Mobile Number")]
        public string  Mobile { get; set; }
        [DisplayName("Work Phone")]
        public string  WorkPhone { get; set; }
        [DisplayName("Home Phone")]
        public string HomePhone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
