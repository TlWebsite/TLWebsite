// Copyright (c) Lakithu. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLWebsite.Data.DTO
{
    public class PostTag
    {
        public int PostTagID { get; set; }

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

        public ICollection<BlogPost> BlogPost { get; set; }

        public ICollection<StoryPost> StoryPost { get; set; }
    }
}
