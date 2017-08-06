// Copyright (c) Lakithu. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLWebsite.Data.DTO
{
    public class BlogPost
    {
        public int BlogPostID { get; set; }
        public Nullable<int> Post_Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CreatedByID { get; set; }
        public int? UpdatedByID { get; set; }
        public int? ArchivedByID { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public Nullable<System.DateTime> ArchivedAt { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public User CreatedBy { get; set; }
        public User UpdatedBy { get; set; }
        public User ArchivedBy { get; set; }
        public ICollection<BlogComment> BlogComment { get; set; }
        public ICollection<MediaInsert> MediaInsert { get; set; }
        public ICollection<TextInsert> TextInsert { get; set; }
        public ICollection<PostTag> PostTag { get; set; }
    }
}
