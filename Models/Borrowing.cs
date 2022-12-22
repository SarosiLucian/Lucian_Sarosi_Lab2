using Lucian_Sarosi_Lab2.Migrations;
using System.ComponentModel.DataAnnotations;

namespace Lucian_Sarosi_Lab2.Models
{
    public class Borrowing
    {
        public int ID { get; set; }
        public int? MemberID { get; set; }
        public Member? Member { get; set; }
        public int? BookID { get; set; }
        public Book? Book { get; set; }
        [DataType(DataType.Date)] public DateTime ReturnDate { get; set; }


    }
}
