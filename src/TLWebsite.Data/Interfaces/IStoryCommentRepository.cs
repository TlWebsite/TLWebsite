// Copyright (c) Lakithu. All rights reserved.

using System.Collections.Generic;

namespace TLWebsite.Data.Interfaces
{
    public interface IStoryCommentRepository : IBaseRepository<StoryComment>
    {
        IEnumerable<StoryComment> GetStoryCommentsByUser(User user);

        IEnumerable<StoryComment> GetStoryCommentsByUser(int userID);

        IEnumerable<StoryComment> GetStoryCommentByUserAndStoryPost(User user, StoryPost storyPost);

        IEnumerable<StoryComment> GetStoryCommentByUserAndStoryPost(int userID, int storyPostID);

        IEnumerable<StoryComment> GetStoryCommentByUserAndStory(User user, Story story);

        IEnumerable<StoryComment> GetStoryCommentByUserAndStory(int userID, int storyID);

        StoryComment GetStoryCommentWithChildren(int storyCommentID);

        StoryComment GetStoryCommentWithChildren(StoryComment storyComment);
    }
}
