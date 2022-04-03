using PersonalBlog.Interface;
using PersonalBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalBlog.Persistence
{
    public class PersonalBlogRepository : IBlogRepository
    {
        private readonly PersonalBlogContext _dataContext;

        public PersonalBlogRepository(PersonalBlogContext context)
        {
            _dataContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Update(BlogPost post)
        {
            _dataContext.Entry(post).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dataContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var post = _dataContext.Posts.Find(id);

            if (post != null)
            {
                _dataContext.Posts.Remove(post);
                _dataContext.SaveChanges();
            }
        }

        public void Add(BlogPost post)
        {
            _dataContext.Posts.Add(post);
            _dataContext.SaveChanges();
        }

        public BlogPost Get(int id)
        {
            return _dataContext.Posts.FirstOrDefault(m => m.PostId == id);
        }

        public IEnumerable<BlogPost> List()
        {
            return _dataContext.Posts.ToList();
        }
    }
}
