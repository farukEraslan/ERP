using ERP.DAL.Configuration;
using ERP.Entities.Abstract;
using ERP.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DAL.Context
{
    public class ERPContext : DbContext
    {
        public ERPContext(DbContextOptions<ERPContext> options) : base(options) 
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = desktop-ufhr98h; Database = ERPProject; uid = sa; pwd = 123;");
        }

        public virtual DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified).ToList();

            string ipAddress = "127.0.0.1";
            DateTime date = DateTime.Now;

            foreach (var item in modifiedEntries)
            {
                CoreEntity entity = item.Entity as CoreEntity;

                if (entity != null) 
                {
                    switch (item.State)
                    {
                        case EntityState.Modified:
                            entity.ModifiedIP = ipAddress;
                            entity.ModifiedDate = date;
                            break;
                        case EntityState.Added:
                            entity.CreatedIP = ipAddress;
                            entity.CreatedDate= date;
                            break;
                        default:
                            break;
                    }
                }
            }

            return base.SaveChanges();
        }
    }
}
