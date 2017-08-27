using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLWebsite.Data.Interfaces
{
    public interface IStoryPostRepository : IBaseRepository<StoryPost>
    {
        IEnumerable<StoryPost> GetStoryPostsByUser(User user);

        IEnumerable<StoryPost> GetStoryPostsByUser(int userID);

        IEnumerable<StoryPost> GetStoryPostsByUserWithComments(User user);

        IEnumerable<StoryPost> GetStoryPostsByUserWithComments(int userID);

        IEnumerable<StoryPost> GetStoryPostsByStory(Story story);

        IEnumerable<StoryPost> GetStoryPostsByStory(int storyID);

        IEnumerable<StoryPost> GetStoryPostsByStoryWithComments(Story story);

        IEnumerable<StoryPost> GetStoryPostsByStoryWithComments(int storyID);

        StoryPost GetStoryPostWithComments(StoryPost storyPost);

        StoryPost GetStoryPostWithComments(int storyPostID);

        IEnumerable<StoryPost> GetStoryPostsByPostTag(PostTag postTag);

        IEnumerable<StoryPost> GetStoryPostsByPostTag(int postTagID);

        IEnumerable<StoryPost> GetStoryPostsByPostTagWithComments(PostTag postTag);

        IEnumerable<StoryPost> GetStoryPostsByPostTagWithComments(int postTagID);

    }
}
