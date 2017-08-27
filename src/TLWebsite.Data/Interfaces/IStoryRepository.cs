// Copyright (c) Lakithu. All rights reserved.

using System.Collections.Generic;

namespace TLWebsite.Data.Interfaces
{
    public interface IStoryRepository : IBaseRepository<Story>
    {
        IEnumerable<Story> GetStoryByUser(User user);

        IEnumerable<Story> GetStoryByUser(int userID);

        IEnumerable<Story> GetFullStoryByUser(User user);

        IEnumerable<Story> GetFullStoryByUser(int userID);

        Story GetFullStory(Story story);

        Story GetFullStory(int storyID);
    }
}
