using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OurBookWorld.UI.Models
{
    public class UserContactsViewModel
    {
        [Key]
        public int UserNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
    }
}
