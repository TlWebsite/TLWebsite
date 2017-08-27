// Copyright (c) Lakithu. All rights reserved.

using System.Collections.Generic;

namespace TLWebsite.Data.Interfaces
{
    public interface IBlogPostRepository : IBaseRepository<BlogPost>
    {
        IEnumerable<BlogPost> GetBlogPostsByUser(User user);

        IEnumerable<BlogPost> GetBlogPostsByUser(int userID);

        IEnumerable<BlogPost> GetBlogPostsByUserWithComments(User user);

        IEnumerable<BlogPost> GetBlogPostsByUserWithComments(int userID);

        BlogPost GetBlogPostWithComments(BlogPost blogPost);

        BlogPost GetBlogPostWithComments(int blogPostID);

    }
}
