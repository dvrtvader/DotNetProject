using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetProject.Models
{
    public class ReadingCard
    {
        public int id { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public List<BookReadingCardR> bookReadingCardRs { get; set; }

    }
}