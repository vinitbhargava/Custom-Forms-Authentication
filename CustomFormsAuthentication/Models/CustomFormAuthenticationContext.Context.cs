﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomFormsAuthentication.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CustomFormAuthenticationEntities : DbContext
    {
        public CustomFormAuthenticationEntities()
            : base("name=CustomFormAuthenticationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<RoleMaster> RoleMaster { get; set; }
        public virtual DbSet<UserRolesMapping> UserRolesMapping { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
