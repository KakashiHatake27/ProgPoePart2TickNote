﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgPoeTickNotePart2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TickNoteEntities : DbContext
    {
        public TickNoteEntities()
            : base("name=TickNoteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<module> modules { get; set; }
        public virtual DbSet<studySession> studySessions { get; set; }
        public virtual DbSet<userAccount> userAccounts { get; set; }
    }
}