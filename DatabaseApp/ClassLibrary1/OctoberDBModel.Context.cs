﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OctoberDBEntities : DbContext
    {
        public OctoberDBEntities()
            : base("name=OctoberDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Screening> Screenings { get; set; }
        public virtual DbSet<Theater> Theaters { get; set; }
    }
}