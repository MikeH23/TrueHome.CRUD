using ActividadCRUD.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadCRUD.Service
{
    public interface IActivityService
    {
        void agregarActividad(Activity activity);
        void actualizarActividad(Activity activity);
        void cancelarActividad(int idActividad);
        List<Activity> GetActivities();
    }
}
