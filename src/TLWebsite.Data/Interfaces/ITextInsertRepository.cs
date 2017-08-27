using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLWebsite.Data.Interfaces
{
    public interface ITextInsertRepository: IBaseRepository<TextInsert>
    {
        void AddTextInsertToBlogPost(int textInsertID, int blogPostID);

        void AddTextInsertToStoryPost(int textInsertID, int storyPostID);

        void AddTextInsertToBlogPost(TextInsert textInsert, BlogPost blogPost);

        void AddTextInsertToStoryPost(TextInsert textInsert, StoryPost storyPost);
    }
}
