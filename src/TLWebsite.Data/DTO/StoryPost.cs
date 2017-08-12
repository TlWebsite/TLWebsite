// Copyright (c) Lakithu. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLWebsite.Data.DTO
{
    public class StoryPost
    {
        public int StoryPostID { get; set; }

        public int StoryID { get; set; }

        public int? Post_Number { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? CreatedByID { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? UpdatedByID { get; set; }

        public DateTime? ArchivedAt { get; set; }

        public int? ArchivedByID { get; set; }

        public bool? IsActive { get; set; }

        public ICollection<MediaInsert> MediaInsert { get; set; }

        public Story Story { get; set; }

        public ICollection<StoryComment> StoryComment { get; set; }

        public User CreatedBy { get; set; }

        public User UpdatedBy { get; set; }

        public User ArchivedBy { get; set; }

        public ICollection<TextInsert> TextInsert { get; set; }

        public ICollection<PostTag> PostTag { get; set; }
    }
}
