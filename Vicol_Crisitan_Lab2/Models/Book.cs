using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using System.Xml.Linq;

namespace Vicol_Crisitan_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public string Title { get; set; }
        
        [Display(Name = "Book Title")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }  //navigation property

        public int? AuthorID { get; set; }

        public Author? Author { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }


    }
}
