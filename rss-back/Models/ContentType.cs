using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rss_back.Models
{
    public class ContentType
    {

       
        public int Id { get; set; }
        public string Url { get; set; }

        public T_Content Type { get; set; }
        [Column(TypeName ="text")]
        public string Contenu { get; set; }

        public enum T_Content
        {
            SRC, TEXT
        }
    }
}
