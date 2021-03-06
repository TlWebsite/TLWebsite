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
    using System.Collections.Generic;
    
    public partial class BlogComment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BlogComment()
        {
            this.BlogComment1 = new HashSet<BlogComment>();
        }
    
        public int BlogCommentID { get; set; }
        public int BlogPostID { get; set; }
        public Nullable<int> Parent { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> ArchivedAt { get; set; }
        public Nullable<int> ArchivedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual BlogPost BlogPost { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogComment> BlogComment1 { get; set; }
        public virtual BlogComment BlogComment2 { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
    }
}
