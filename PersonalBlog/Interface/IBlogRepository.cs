using PersonalBlog.Models;
using System.Collections.Generic;

namespace PersonalBlog.Interface
{
    public interface IBlogRepository
    {
        void Update(BlogPost post);
        void Delete(int id);
        void Add(BlogPost post);
        IEnumerable<BlogPost> List();
        BlogPost Get(int id);
    }
}