using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic.DTO;
using BusinessLogic.Servicios;
using Newtonsoft.Json.Linq;

namespace PrbMasGlobal.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<EmpleadoDTO> Get(string identificacion)
        {
            return EmpleadoServicios.GetEmpleadosOrEmpleado(identificacion);
        }



    }
}