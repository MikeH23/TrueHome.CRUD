using ActividadCRUD.Models.DTO;
using ActividadCRUD.Models.Entity;
using ActividadCRUD.Models.Request;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadCRUD.Repository.Repositorio
{
    public class RepositorioActivity : IRepositorioActivity
    {
        //------------------------------------------------------------
        private ActividadesDBContext _contexto;
        private DbSet<Activity> _dbSet;
        //------------------------------------------------------------
        public RepositorioActivity(ActividadesDBContext contexto)
        {
            _contexto = contexto;
            this._dbSet = _contexto.Set<Activity>();
        }
        //------------------------------------------------------------
        public List<Activity> GetActivities()
        {
            try
            {
                return _dbSet.OrderBy(x => x.id).ToList(); //.Include(x => x.property).ToList();
            } 
            catch(NotImplementedException e)
            {
                throw e;
            }
        }

        public void agregarActividad(AddActivityRequest activity)
        {
            try
            {
                var property = _contexto.Property.Where(x => x.id == activity.property_id).FirstOrDefault();

                Activity objActivity = new Activity();

                objActivity.property_id = activity.property_id;
                objActivity.schedule = activity.schedule;
                objActivity.title = activity.title;
                objActivity.created_at = DateTime.Now;
                objActivity.updated_at = DateTime.Now;
                objActivity.status = activity.status;

                _dbSet.Add(objActivity);
                _contexto.SaveChanges();

            } 
            catch( NotImplementedException e)
            {
                throw e;
            }
        }


        public void actualizarActividad(Activity activity)
        {
            try
            {        
                _dbSet.Update(activity);
                _contexto.SaveChanges();
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
                _dbSet.Update(activity);
                _contexto.SaveChanges();
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
                DateTime dtFecha = DateTime.Now;
                ActivityDTO activityDTO = new ActivityDTO();
                List<ActivityDTO> lstActivityDTO = new List<ActivityDTO>();
                List<Activity> lstActividad = new List<Activity>();
                lstActividad = _dbSet.Where(x => dtFecha.AddDays(-3) <= x.schedule && x.schedule <= dtFecha.AddDays(2)).OrderBy(x => x.id).ToList();

                foreach (Activity item in lstActividad)
                {
                    activityDTO.id = item.id;
                    activityDTO.schedule = item.schedule;
                    activityDTO.title = item.title;
                    activityDTO.created_at = item.created_at;
                    activityDTO.status = item.status;
                    lstActivityDTO.Add(activityDTO);
                }

                return lstActivityDTO;
            }
            catch (NotImplementedException e)
            {
                throw e;
            }
        }
    }
}
