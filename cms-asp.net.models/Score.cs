//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cms_asp.net.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Score
    {
        public System.Guid ScoreID { get; set; }
        public System.DateTime Date { get; set; }
        public System.Guid ImagesScoreID { get; set; }
        public bool IsLike { get; set; }
    
        public virtual ImagesScore ImagesScore { get; set; }
    }
}