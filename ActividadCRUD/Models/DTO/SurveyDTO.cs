using ActividadCRUD.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadCRUD.Models.DTO
{
    public class SurveyDTO
    {
        public int id { get; set; }
        public Activity activity { get; set; }
        public string answers { get; set; }
        public DateTime created_at { get; set; }

        public SurveyDTO()
        {

        }
    }
}
