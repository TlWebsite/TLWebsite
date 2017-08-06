//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TLWebsite.Data
{
    using System;

    public partial class MediaInsert
    {
        public int MediaInsertID { get; set; }
        public int MediaID { get; set; }
        public Nullable<int> BlogPostID { get; set; }
        public Nullable<int> StoryPostID { get; set; }
        public int OrderNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> ArchivedAt { get; set; }
        public Nullable<int> ArchivedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual BlogPost BlogPost { get; set; }
        public virtual Medium Medium { get; set; }
        public virtual StoryPost StoryPost { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
    }
}
