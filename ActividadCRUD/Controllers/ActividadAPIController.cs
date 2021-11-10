using ActividadCRUD.Models.Entity;
using ActividadCRUD.Repository.Repositorio;
using ActividadCRUD.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadCRUD.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ActividadAPIController : ControllerBase
    {
        //-------------------------------------------------------------------------------------------
        private readonly IActivityService _activityService;
        private readonly IRepositorioActivity _repositorioActivity;
        //-------------------------------------------------------------------------------------------
        public ActividadAPIController(IActivityService activityService, IRepositorioActivity repositorioActivity)
        {
            this._activityService = activityService;
            this._repositorioActivity = repositorioActivity;
        }
        //-------------------------------------------------------------------------------------------
        [HttpGet("obtenerActividades")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public  IEnumerable<Activity> obtenerActividades()
        {
            try
            {
                var lstActividad = _repositorioActivity.GetActivities();
                return lstActividad;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
