using ActividadCRUD.Models.Entity;
using ActividadCRUD.Repository.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadCRUD.Service
{
    public class ActivityService : IActivityService
    {
        //-------------------------------------------------------
        private readonly IRepositorioActivity _repositorioActivity;
        //-------------------------------------------------------
        public ActivityService(IRepositorioActivity repositorioActivity)
        {
            this._repositorioActivity = repositorioActivity;
        }
        //-------------------------------------------------------
        public void agregarActividad(Activity activity)
        {
            try
            {
                 _repositorioActivity.agregarActividad(activity);
            }
            catch (NotImplementedException e)
            {
                throw e;
            }
        }

        public void actualizarActividad(Activity activity)
        {
            try
            {
                _repositorioActivity.actualizarActividad(activity);
            } catch(NotImplementedException e)
            {
                throw e;
            }
        }

        public void cancelarActividad(int idActividad)
        {
            try
            {
                _repositorioActivity.cancelarActividad(idActividad);
            }
            catch (NotImplementedException e)
            {
                throw e;
            }
        }

        public List<Activity> GetActivities()
        {
            try
            {
                return _repositorioActivity.GetActivities();
            }
            catch (NotImplementedException e)
            {
                throw e;
            }
        }
    }
}
