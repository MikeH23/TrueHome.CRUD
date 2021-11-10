using ActividadCRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadCRUD.Repository.Configuracion
{
    public class PropertyConfig : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> entity)
        {
            entity.HasKey(e => e.id);
            entity.Property(e => e.id).HasColumnName("id");
            entity.Property(e => e.title).HasColumnName("title");
            entity.Property(e => e.address).HasColumnName("address");
            entity.Property(e => e.description).HasColumnName("description");
            entity.Property(e => e.created_at).HasColumnName("created_at");
            entity.Property(e => e.updated_at).HasColumnName("updated_at");
            entity.Property(e => e.disabled_at).HasColumnName("disabled_at");
            entity.Property(e => e.status).HasColumnName("status");
        }
    }
}
