using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadCRUD.Models.Entity
{
    public class Survey
    {
        public int id { get; set; } 
        [ForeignKey("activity_id")]
        public virtual Activity activity { get; set; }
        public string answers { get; set; }
        public DateTime created_at { get; set; }

        public Survey()
        {

        }
    }
}
