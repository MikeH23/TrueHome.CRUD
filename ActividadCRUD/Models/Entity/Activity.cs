using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadCRUD.Models.Entity
{
    public class Activity
    {
        public int id { get; set; }

        [ForeignKey("property_id")]
        public virtual Property property { get; set; }
        public DateTime schedule { get; set;  }
        public string title { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string status { get; set; }

        public Activity()
        {

        }
    }
}
