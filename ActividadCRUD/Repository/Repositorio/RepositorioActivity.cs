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
                return _dbSet.OrderBy(x => x.id).Include(x => x.property).ToList();
            } catch(NotImplementedException e)
            {
                throw e;
            }
        }


        public void actualizarActividad(Activity activity)
        {
            throw new NotImplementedException();
        }

        public void agregarActividad(Activity activity)
        {
            throw new NotImplementedException();
        }

        public void cancelarActividad(int idActividad)
        {
            throw new NotImplementedException();
        }
    }
}
