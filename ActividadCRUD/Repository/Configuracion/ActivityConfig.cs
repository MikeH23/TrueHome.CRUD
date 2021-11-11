using ActividadCRUD.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadCRUD.Repository.Configuracion
{
    public class ActivityConfig : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> entity)
        {
            entity.HasKey(e => e.id);
            entity.Property(e => e.id).HasColumnName("id");
            entity.Property(e => e.property_id).HasColumnName("property_id");
            entity.Property(e => e.schedule).HasColumnName("schedule");
            entity.Property(e => e.title).HasColumnName("title");           
            entity.Property(e => e.created_at).HasColumnName("created_at");
            entity.Property(e => e.updated_at).HasColumnName("updated_at");
            entity.Property(e => e.status).HasColumnName("status");
        }
    }
}
