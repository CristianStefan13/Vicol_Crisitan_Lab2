using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Vicol_Crisitan_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "Author")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
