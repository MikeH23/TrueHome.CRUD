using ActividadCRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadCRUD.Repository.Repositorio
{
    public class RepositorioProperty : IRepositorioProperty
    {
        //------------------------------------------------------------
        private ActividadesDBContext _contexto;
        private DbSet<Property> _dbSet;
        //------------------------------------------------------------
        public RepositorioProperty(ActividadesDBContext contexto)
        {
            _contexto = contexto;
            this._dbSet = _contexto.Set<Property>();
        }
        //------------------------------------------------------------
        public Property GetProperties(int idProperty)
        {
            try
            {
                return _dbSet.Where(x => x.id == idProperty).FirstOrDefault(); 
            }
            catch (NotImplementedException e)
            {
                throw e;
            }
        }
    }
}
