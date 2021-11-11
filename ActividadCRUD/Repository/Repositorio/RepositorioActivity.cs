using ActividadCRUD.Models.Entity;
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

        public void agregarActividad(Activity activity)
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

        public void cancelarActividad(int idActividad)
        {
            throw new NotImplementedException();
        }
    }
}
