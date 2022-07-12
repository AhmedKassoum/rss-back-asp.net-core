namespace rss_back.Models
{
    public class CreatorType
    {
        public enum T_Creator
        {
            AUTHOR,CONTRIBUTOR
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
        public string Mail { get; set; }
        public T_Creator Type { get; set; }
    }
}
