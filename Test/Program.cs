using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Z.EntityFramework.Plus;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // database migration
            using (var context = new MyDbContext())
            {
                context.Database.Migrate();
            }

            // add a user
            SysUser user = new SysUser
            {
                Id = Guid.NewGuid().ToString(),
                Status = "1"
            };
            using (var context = new MyDbContext())
            {
                context.SysUsers.Add(user);
                context.SaveChanges();
            }

            // test Z.EntityFramework.Plus.EFCore update
            using (var context = new MyDbContext())
            {
                context.SysUsers.Where(x => x.Id == user.Id).Update(x => new SysUser { Status = x.Status + "1" });
            }

            Console.ReadKey();
        }
    }
}
