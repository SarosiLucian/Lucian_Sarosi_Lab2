﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Security.Policy;
using Lucian_Sarosi_Lab2.Migrations;

namespace Lucian_Sarosi_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        [Required, StringLength(150, MinimumLength = 3)]
        public string Title { get; set; }
    //    [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$", ErrorMessage = "Numele autorului trebuie sa fie de forma 'Prenume Nume'"), Required, StringLength(50, MinimumLength = 3)]
      //  public string Author { get; set; }
        
        [Range(1, 300)]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? AuthorID { get; set; }

        public Author? Author { get; set; }


        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; } //navigation property

        public ICollection<BookCategory>? BookCategories { get; set; }

    }
}
