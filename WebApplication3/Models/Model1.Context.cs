﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookRentalEntities : DbContext
    {
        public BookRentalEntities()
            : base("name=BookRentalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AuthorTable> AuthorTables { get; set; }
        public virtual DbSet<BookDetailTable> BookDetailTables { get; set; }
        public virtual DbSet<BookTable> BookTables { get; set; }
        public virtual DbSet<PublisherTable> PublisherTables { get; set; }
        public virtual DbSet<RentDetailTable> RentDetailTables { get; set; }
        public virtual DbSet<RentTable> RentTables { get; set; }
        public virtual DbSet<RoleTable> RoleTables { get; set; }
        public virtual DbSet<UserInfoTable> UserInfoTables { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }
    }
}
