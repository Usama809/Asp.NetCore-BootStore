using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14_Models_in_Asp.net_Core.Data
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }
        public ICollection<Books> Books { get; set; }
    }
}
