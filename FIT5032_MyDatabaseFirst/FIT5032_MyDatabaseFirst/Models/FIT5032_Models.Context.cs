﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FIT5032_MyDatabaseFirst.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FIT5032_MyDatabaseFirstEntities1 : DbContext
    {
        public FIT5032_MyDatabaseFirstEntities1()
            : base("name=FIT5032_MyDatabaseFirstEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
    }
}
