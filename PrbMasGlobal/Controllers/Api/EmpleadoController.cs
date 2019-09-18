using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic.DTO;
using BusinessLogic.Servicios;

namespace PrbMasGlobal.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        
        [HttpPost]
        public IEnumerable<EmpleadoDTO> Post(string identificacion)
        {
            return EmpleadoServicios.GetEmpleadosOrEmpleado(identificacion);
        }

        [HttpGet]
        public IEnumerable<EmpleadoDTO> Get()
        {
            return EmpleadoServicios.GetEmpleadosOrEmpleado("");
        }



    }
}