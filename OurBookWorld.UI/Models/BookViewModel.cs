using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OurBookWorld.UI.Models
{
    public class BookViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Author { get; set; }
        


    
  
        }
    }


    