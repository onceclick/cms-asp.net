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
    
    public partial class Entry
    {
        public System.Guid EntryID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public System.DateTime Date { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public System.Guid ProfileUserID { get; set; }
    
        public virtual ProfileUser ProfileUser { get; set; }
    }
}
