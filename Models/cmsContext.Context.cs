﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class cmsContext : DbContext
    {
        public cmsContext()
            : base("name=cmsContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CommentImage> CommentImages { get; set; }
        public virtual DbSet<Entry> Entries { get; set; }
        public virtual DbSet<Gallery> Galleries { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<ImagesScore> ImagesScores { get; set; }
        public virtual DbSet<ProfileUser> ProfileUsers { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
    }
}
