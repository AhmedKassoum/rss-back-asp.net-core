
using System.ComponentModel.DataAnnotations;

namespace rss_back.Models
{
    public class Item
    {
        [Key]
        public Guid Guid { get; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string DateType { get; set; }
        public DateTime Date { get; set; }
        public ImageType Image { get; set; }
        public ContentType Content { get; set; }
        public CreatorType Creator { get; set; }

        /*public Item()
        {
            this.Guid= System.Guid.NewGuid().ToString();
        }*/
    }
}
