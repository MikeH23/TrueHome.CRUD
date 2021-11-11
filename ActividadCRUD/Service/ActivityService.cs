using ActividadCRUD.Models.DTO;
using ActividadCRUD.Models.Entity;
using ActividadCRUD.Models.Request;
using ActividadCRUD.Repository.Repositorio;
using Microsoft.AspNetCore.Mvc;
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
        public void agregarActividad(AddActivityRequest activity)
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
            } 
            catch(NotImplementedException e)
            {
                throw e;
            }
        }

        public void cancelarActividad(Activity activity)
        {
            try
            {
                _repositorioActivity.cancelarActividad(activity);
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

        public List<ActivityDTO> obtenerFiltroActividades()
        {
            try
            {
                return _repositorioActivity.obtenerFiltroActividades();
            }
            catch (NotImplementedException e)
            {
                throw e;
            }
        }
    }
}
