﻿//------------------------------------------------------------------------------
// <auto-generated>
//    このコードはテンプレートから生成されました。
//
//    このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//    このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WYsystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WYEntities : DbContext
    {
        public WYEntities()
            : base("name=WYEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<w_admin> w_admin { get; set; }
        public DbSet<w_room_info> w_room_info { get; set; }
        public DbSet<w_system_params> w_system_params { get; set; }
        public DbSet<w_announcement> w_announcement { get; set; }
    }
}
