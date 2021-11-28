using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cacuci_Daciana_Lab8.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Book Title")]
        public string Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
