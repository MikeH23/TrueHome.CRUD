using ActividadCRUD.Models;
using ActividadCRUD.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadCRUD.Repository
{
    public class ActividadesDBContext : DbContext
    {
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<Survey> Survey { get; set; }

        public ActividadesDBContext(DbContextOptions<ActividadesDBContext> options)
         : base(options)
        {

        }
    }
}
