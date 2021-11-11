using ActividadCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadCRUD.Repository.Repositorio
{
    public  interface IRepositorioProperty
    {
        Property GetProperties(int idProperty);
    }
}
