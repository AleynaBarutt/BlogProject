using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contacts
    {
        [Key]
        public int ContactID { get; set; }

        public string ContacUserName { get; set; }

        public string ContactMail { get; set; }

        public string ContactSubject { get; set; }

        public string ContactMessage { get; set; }

        public DateTime ContactDate { get; set; }

        public bool ContactStatus { get; set; }
    }
}
