﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Heat.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HeatEntities : DbContext
    {
        public HeatEntities()
            : base("name=HeatEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Combo> Comboes { get; set; }
        public virtual DbSet<DanceLevel> DanceLevels { get; set; }
        public virtual DbSet<DanceType> DanceTypes { get; set; }
        public virtual DbSet<Pro> Pros { get; set; }
        public virtual DbSet<HeatList> HeatLists { get; set; }
        public virtual DbSet<Couple> Couples { get; set; }
    }
}