// Copyright (c) Lakithu. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLWebsite.Data.DTO
{
    public class TextInsert
    {
        public int TextInsertID { get; set; }

        public int? BlogPostID { get; set; }

        public int? StoryPostID { get; set; }

        public string Value { get; set; }

        public int OrderNumber { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? CreatedByID { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? UpdatedByID { get; set; }

        public DateTime? ArchivedAt { get; set; }

        public int? ArchivedByID { get; set; }

        public bool? IsActive { get; set; }

        public BlogPost BlogPost { get; set; }

        public StoryPost StoryPost { get; set; }

        public User CreatedBy { get; set; }

        public User UpdatedBy { get; set; }

        public User ArchivedBy { get; set; }
    }
}
