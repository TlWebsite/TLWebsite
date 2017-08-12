// Copyright (c) Lakithu. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLWebsite.Data.DTO
{
    public class User
    {
        public int UserID { get; set; }

        public bool? IsAdmin { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int? CreatedByID { get; set; }

        public int? UpdatedByID { get; set; }

        public int? DeactivatedByID { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeactivatedAt { get; set; }

        public bool? IsActive { get; set; }

        public User CreatedBy { get; set; }

        public User UpdatedBy { get; set; }

        public User DeactivatedBy { get; set; }

        public ICollection<BlogComment> BlogComment { get; set; }

        public ICollection<BlogPost> BlogPost { get; set; }

        public ICollection<Media> Media { get; set; }

        public ICollection<Story> Story { get; set; }

        public ICollection<StoryComment> StoryComment { get; set; }

        public ICollection<StoryPost> StoryPost { get; set; }
    }
}