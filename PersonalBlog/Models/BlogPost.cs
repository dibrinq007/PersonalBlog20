using PersonalBlog.Extesions;
using System.ComponentModel.DataAnnotations;

namespace PersonalBlog.Models
{
    public class BlogPost
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public string Link
        {
            get
            {
                return ShortDescription.UrlFriendly(50);
            }
        }

    }
}
