using functionrequire.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace functionrequire.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name = DataContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>("DataContext"));
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<HarkWork> HarkWorks { get; set; }
    }
}