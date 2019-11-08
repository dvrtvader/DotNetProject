using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetProject.Models
{
    public class BookGenreR
    {
        public int bookId { get; set; }
        public Book book { get; set; }
        public int genreId { get; set; }
        public Genre genre { get; set; }
    }
}
