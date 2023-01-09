using ERP.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DAL.Configuration
{
    public class CoreMap<T> : IEntityTypeConfiguration<T> where T : CoreEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Status).IsRequired(true);
            builder.Property(e => e.CreatedDate).IsRequired(false);
            builder.Property(e => e.ModifiedDate).IsRequired(false);
            builder.Property(e => e.CreatedIP).IsRequired(false);
            builder.Property(e => e.ModifiedIP).IsRequired(false);

        }
    }
}
