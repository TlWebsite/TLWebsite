using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLWebsite.Data.Interfaces
{
    public interface IMediaInsertRepository : IBaseRepository<MediaInsert>
    {
        void AddMediaInsertToBlogPost(int mediaInsertID, int blogPostID);

        void AddMediaInsertToStoryPost(int mediaInsertID, int storyPostID);

        void AddMediaInsertToBlogPost(MediaInsert mediaInsert, BlogPost blogPost);

        void AddMediaInsertToStoryPost(MediaInsert mediaInsert, StoryPost storyPost);
    }
}
