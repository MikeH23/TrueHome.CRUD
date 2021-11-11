using ActividadCRUD.Models.DTO;
using ActividadCRUD.Models.Entity;
using ActividadCRUD.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadCRUD.Service
{
    public interface IActivityService
    {
        void agregarActividad(AddActivityRequest activity);
        void actualizarActividad(Activity activity);
        void cancelarActividad(Activity activity);
        List<Activity> GetActivities();
        List<ActivityDTO> obtenerFiltroActividades();
    }
}
