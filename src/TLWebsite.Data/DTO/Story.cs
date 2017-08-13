// Copyright (c) Lakithu. All rights reserved.

using System;
using System.Collections.Generic;

namespace TLWebsite.Data.DTO
{
    public class Story
    {
        public int StoryID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? CreatedByID { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? UpdatedByID { get; set; }

        public DateTime? ArchivedAt { get; set; }

        public int? ArchivedByID { get; set; }

        public bool? IsActive { get; set; }

        public User CreatedBy { get; set; }

        public User UpdatedBy { get; set; }

        public User ArchivedBy { get; set; }

        public ICollection<StoryPost> StoryPost { get; set; }
    }
}
