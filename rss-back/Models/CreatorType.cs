namespace rss_back.Models
{
    public class Creator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
        public string Mail { get; set; }
        public CreatorType Type { get; set; }
    }
}
