using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetProject.Models
{
    public class Author
    {
        public int id { get; set; }

        public string name { get; set; }
        public List<Book> books { get; set; }
    }
}
