using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLWebsite.Data.Interfaces
{
    public interface IBlogCommentRepository : IBaseRepository<BlogComment>
    {
        IEnumerable<BlogComment> GetBlogCommentsByUser(User user);

        IEnumerable<BlogComment> GetBlogCommentsByUser(int userID);

        IEnumerable<BlogComment> GetBlogCommentsByBlogPost(BlogPost blogPost);

        IEnumerable<BlogComment> GetBlogCommentsByBlogPost(int blogPostID);

        IEnumerable<BlogComment> GetBlogCommentByUserAndBlogPost(User user, BlogPost blogPost);

        IEnumerable<BlogComment> GetBlogCommentByUserAndBlogPost(int userID, int blogPostID);

        BlogComment GetBlogCommentWithChildren(int blogCommentID);

        BlogComment GetBlogCommentWithChildren(BlogComment blogComment);
    }
}
