using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OurBookWorld.UI.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }       
        public string Type { get; set; }
        public string Author { get; set; }
        public string UserContacts { get; set; }


    }
    public class ContactModel
    {
       
        public string UserName { get; set; }
      
        public string UserEmail { get; set; }
       
        public string UserPhoneNumber { get; set; }
    }
}
