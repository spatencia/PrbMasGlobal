using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using BusinessLogic.DTO;
using DataAccess.EmpleadoDataAccess;

namespace BusinessLogic.Servicios
{
    public class EmpleadoServicios
    {

        EmpleadoDataAccess EmpleadoDataAccess = new EmpleadoDataAccess();

        public List<EmpleadoDTO> GetEmpleadosOrEmpleado(string identificacion)
        {
            DataTable Result = new DataTable();
            List<EmpleadoDTO> ListaEmpleado = new List<EmpleadoDTO>();
            try
            {
                if (string.IsNullOrEmpty(identificacion))
                    Result = EmpleadoDataAccess.ObtenerTodosEmpleados();
                else
                    Result = EmpleadoDataAccess.ObtenerEmpleadoByIdentificacion(identificacion);


                if (Result.Rows.Count > 0)
                    foreach(DataRow row in Result.Rows)
                    {
                        
                    }


            }
            catch (Exception)
            {

                throw;
            }
            return Result;
        }







    }
}
