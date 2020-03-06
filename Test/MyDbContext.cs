using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("Server=localhost;database=test_zefplus;uid=root;pwd=xxxxxx;port=3306;CharSet=utf8");
        }

        public DbSet<SysUser> SysUsers { get; set; }
    }
}
