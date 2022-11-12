using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lucian_Sarosi_Lab2.Models
{
        public class Author
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public ICollection<Book>? Books { get; set; }
            [Display(Name = "Full Name")]
            public string FullName
            {
                get
                {
                    return FirstName + " " + LastName;
                }

            }
        }
    }


