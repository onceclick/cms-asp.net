//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Image
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Image()
        {
            this.CommentImages = new HashSet<CommentImage>();
            this.ImagesScores = new HashSet<ImagesScore>();
        }
    
        public System.Guid ImageID { get; set; }
        public System.DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageP { get; set; }
        public System.Guid ProfileUserID { get; set; }
        public System.Guid GalleryID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentImage> CommentImages { get; set; }
        public virtual Gallery Gallery { get; set; }
        public virtual ProfileUser ProfileUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImagesScore> ImagesScores { get; set; }
    }
}
