﻿using PersonalBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Services
{
    public interface IBlogService
    {
        List<BlogPost> GetBlogPosts();

        string GetPostText(string link);
    }
}