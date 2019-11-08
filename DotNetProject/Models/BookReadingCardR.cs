using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetProject.Models
{
    public class BookReadingCardR
    {
        public int bookId { get; set; }
        public Book book { get; set; }
        public int readingCardId { get; set; }
        public ReadingCard readingCard { get; set; }
    }
}
