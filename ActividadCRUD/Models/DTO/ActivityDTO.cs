using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadCRUD.Models.DTO
{
    public class ActivityDTO
    {
        public int id { get; set; }
        public Property property { get; set; }
        public DateTime schedule { get; set; }
        public string title { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string status { get; set; }

        public ActivityDTO()
        {

        }
    }
}
