// Copyright (c) Lakithu. All rights reserved.

using System.Collections.Generic;

namespace TLWebsite.Data.DTO
{
    public class AllComments
    {
        public AllComments()
        {
            this.BlogComments = new List<BlogComment>();
            this.StoryComments = new List<StoryComment>();
        }

        public List<BlogComment> BlogComments { get; set; }

        public List<StoryComment> StoryComments { get; set; }
    }
}
