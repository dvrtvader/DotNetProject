using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetProject.Models
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string imageUrl { get; set; }
        public List<Genre> genres { get; set; }
        public int authorId { get; set; }
        public Author author { get; set; }
        public int posterId { get; set; }
        public Poster poster { get; set; }
        public List<BookGenreR> bookGenreR { get; set; }
        public List<BookReadingCardR> bookReadingCardR { get; set; }

    }
}
