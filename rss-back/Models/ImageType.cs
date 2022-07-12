namespace rss_back.Models
{
    public class ImageType
    {
        public enum T_IMAGE
        {
            JPEG,PNG,JPG,BMP
        }
        public int Id { get; set; }
        public string Url { get; set; }
        public int Taille { get; set; }
        public string Description { get; set; }
        public T_IMAGE Type { get; set; }
    }
}
