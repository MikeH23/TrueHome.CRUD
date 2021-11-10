using ActividadCRUD.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadCRUD.Models.DTO
{
    public class SurveyConfig : IEntityTypeConfiguration<Survey>
    {
        public void Configure(EntityTypeBuilder<Survey> entity)
        {
            entity.HasKey(e => e.id);
            entity.Property(e => e.id).HasColumnName("id");
            entity.Property(e => e.activity.id).HasColumnName("activity_id");
            entity.Property(e => e.answers).HasColumnName("answers");
            entity.Property(e => e.created_at).HasColumnName("created_at");
        }
    }
}
