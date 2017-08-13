// Copyright (c) Lakithu. All rights reserved.

using System;
using System.Collections.Generic;

namespace TLWebsite.Data.DTO
{
    public class StoryComment
    {
        public int StoryCommentID { get; set; }

        public int StoryPostID { get; set; }

        public int? ParentID { get; set; }

        public string Comment { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? CreatedByID { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? UpdatedByID { get; set; }

        public DateTime? ArchivedAt { get; set; }

        public int? ArchivedByID { get; set; }

        public bool? IsActive { get; set; }

        public StoryPost StoryPost { get; set; }

        public ICollection<StoryComment> Children { get; set; }

        public StoryComment Parent { get; set; }

        public User CreatedBy { get; set; }

        public User UpdatedBy { get; set; }

        public User ArchivedBy { get; set; }
    }
}
