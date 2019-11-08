using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetProject.Models
{
    public class User
    {
        public int id { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public int readingCardId { get; set; }

        public ReadingCard readingCard { get; set; }
    }
}
