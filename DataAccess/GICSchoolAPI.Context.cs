﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class schoolManagementEntities2 : DbContext
{
    public schoolManagementEntities2()
        : base("name=schoolManagementEntities2")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<@class> classes { get; set; }
    public virtual DbSet<family_members> family_members { get; set; }
    public virtual DbSet<homework> homework { get; set; }
    public virtual DbSet<parent> parents { get; set; }
    public virtual DbSet<report> reports { get; set; }
    public virtual DbSet<stdent_families> stdent_families { get; set; }
    public virtual DbSet<student_addresses> student_addresses { get; set; }
    public virtual DbSet<student_parents> student_parents { get; set; }
    public virtual DbSet<subject> subjects { get; set; }
    public virtual DbSet<teacher> teachers { get; set; }
    public virtual DbSet<student> students { get; set; }
    public virtual DbSet<address> addresses { get; set; }
    public virtual DbSet<school_addresses> school_addresses { get; set; }
    public virtual DbSet<parent_addresses> parent_addresses { get; set; }
    public virtual DbSet<school> schools { get; set; }
    public virtual DbSet<student_classes> student_classes { get; set; }
}