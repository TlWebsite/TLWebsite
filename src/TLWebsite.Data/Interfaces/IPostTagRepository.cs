using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLWebsite.Data.Interfaces
{
    public interface IPostTagRepository : IBaseRepository<PostTag>
    {
        void RemovePostTagFromBlogPost(int postTagID, int blogPostID);

        void RemovePostTagFromBlogPost(PostTag postTag, BlogPost blogPost);

        void RemovePostTagFromStoryPost(int postTagID, int storyPostID);

        void RemovePostTagFromStoryPost(PostTag postTag, BlogPost storyPost);

        void AddPostTagToBlogPost(int postTagID, int blogPostID);

        void AddPostTagToBlogPost(PostTag postTag, BlogPost blogPost);

        void AddPostTagToStoryPost(int postTagID, int storyPostID);

        void AddPostTagToStoryPost(PostTag postTag, BlogPost storyPost);

        void RemoveBulkPostTagsFromBlogPost(IEnumerable<int> postTagID, int blogPostID);

        void RemoveBulkPostTagsFromBlogPost(IEnumerable<PostTag> postTag, BlogPost blogPost);

        void RemoveBulkPostTagsFromStoryPost(IEnumerable<int> postTagID, int storyPostID);

        void RemoveBulkPostTagsFromStoryPost(IEnumerable<PostTag> postTag, BlogPost storyPost);

        void AddBulkPostTagsToBlogPost(IEnumerable<int> postTagID, int blogPostID);

        void AddBulkPostTagsToBlogPost(IEnumerable<PostTag> postTag, BlogPost blogPost);

        void AddBulkPostTagsToStoryPost(IEnumerable<int> postTagID, int storyPostID);

        void AddBulkPostTagsToStoryPost(IEnumerable<PostTag> postTag, BlogPost storyPost);
    }
}
