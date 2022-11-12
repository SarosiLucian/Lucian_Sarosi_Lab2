using Lucian_Sarosi_Lab2.Models;
namespace Lucian_Sarosi_Lab2.Models.View_Models
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
