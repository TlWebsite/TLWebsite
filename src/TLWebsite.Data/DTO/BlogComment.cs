// Copyright (c) Lakithu. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLWebsite.Data.DTO
{
    public class BlogComment
    {
        public int BlogCommentID { get; set; }

        public int BlogPostID { get; set; }

        public string Comment { get; set; }

        public int? CreatedByID { get; set; }

        public int? UpdatedByID { get; set; }

        public int? ArchivedByID { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? ArchivedAt { get; set; }

        public bool? IsActive { get; set; }

        public User CreatedBy { get; set; }

        public User UpdatedBy { get; set; }

        public User ArchivedBy { get; set; }

        public BlogComment Parent { get; set; }

        public BlogPost BlogPost { get; set; }

        public ICollection<BlogComment> Children { get; set; }
    }
}
