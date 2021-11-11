using ActividadCRUD.Models;
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
        private readonly IRepositorioProperty _repositorioProperty;
        //-------------------------------------------------------------------------------------------
        public ActividadAPIController(IActivityService activityService, IRepositorioActivity repositorioActivity, IRepositorioProperty repositorioProperty)
        {
            this._activityService = activityService;
            this._repositorioActivity = repositorioActivity;
            this._repositorioProperty = repositorioProperty;
        }
        //-------------------------------------------------------------------------------------------
        [HttpGet("obtenerActividades")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Activity> obtenerActividades()
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
        //-------------------------------------------------------------------------------------------
        [HttpPost("agregarActividad")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult agregarActividad(Activity activity)
        {
            try
            {
                Property lstProperty = new Property();
                List<Activity> lstActivity = new List<Activity>();

                if (ModelState.IsValid)
                {
                    lstProperty = _repositorioProperty.GetProperties(activity.property_id);
                    lstActivity = _repositorioActivity.GetActivities();

                    if (lstProperty != null)
                    {
                        if (lstProperty.disabled_at == null)
                        {

                            var rangoActividad = lstActivity.Where(x => x.property_id == activity.property_id && activity.schedule > x.schedule && activity.schedule < x.schedule.AddHours(1)).ToList();

                            if (rangoActividad.Count == 0)
                            {
                                _repositorioActivity.agregarActividad(activity);
                                return Ok("Actividad ingresada de manera correcta...");
                            }
                            else
                            {
                                var msj = "No se puede ingresar la actividad debido a que aun existe una actividad activa para la propiedad seleccionada, favor de verficiar...";
                                return BadRequest(msj);
                            }
                        }
                        else
                        {
                            var msj = "La propiedad seleccionada esta inactiva, favor de verificar...";
                            return BadRequest(msj);
                        }
                    }
                    else
                    {
                        var msj = "La propiedad seleccionada no esta en el catalogo Property, favor de verificar...";
                        return BadRequest(msj);
                    }
                }

                return BadRequest();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //-------------------------------------------------------------------------------------------
        [HttpPost("actualizarActividad")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult actualizarActividad(Activity activity)
        {
            try
            {
                int id = activity.id;
                DateTime schedule = activity.schedule;
                List<Activity> lstActivity = new List<Activity>();
                Activity objActivity = new Activity();

                if (ModelState.IsValid)
                {
                    lstActivity = _repositorioActivity.GetActivities().Where(x => x.id == id).ToList();
                    objActivity = lstActivity.Where(x => x.id == id).FirstOrDefault();

                    if(objActivity != null && objActivity.status != "Cancelada")
                    {
                        var rangoActividad = lstActivity.Where(x => x.property_id == objActivity.property_id && schedule == x.schedule && schedule < x.schedule.AddHours(1)).ToList();

                        if (rangoActividad.Count == 0 )
                        {
                            if (schedule != objActivity.schedule && objActivity.property_id == activity.property_id && objActivity.title == activity.title && objActivity.created_at == activity.created_at && 
                                objActivity.updated_at == activity.updated_at && objActivity.status == activity.status)
                            {
                                objActivity.schedule = schedule;
                                _repositorioActivity.actualizarActividad(objActivity);
                                return Ok("Actividad actualizada de manera correcta...");
                            }
                            else
                            {
                                var msj = "Unicamente se puede actualizar el campo 'Schedule', favor de verficiar...";
                                return BadRequest(msj);
                            }                            
                        }
                        else
                        {
                            var msj = "No se puede actualizar la actividad por que el horario seleccionado no esta disponible, favor de verficiar...";
                            return BadRequest(msj);
                        }                           
                    }
                    else
                    {
                        var msj = "La actividad que deseas actualizar se encuentra cancelada, favor de verificar...";
                        return BadRequest(msj);
                    }
                } 

                return BadRequest();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
