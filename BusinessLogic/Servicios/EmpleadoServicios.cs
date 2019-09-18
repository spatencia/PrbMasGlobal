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

        public static List<EmpleadoDTO> GetEmpleadosOrEmpleado(string identificacion)
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
                        EmpleadoDTO emp = new EmpleadoDTO(int.Parse(row.ItemArray[0].ToString()),
                                                          row.ItemArray[1].ToString(),
                                                          row.ItemArray[2].ToString(),
                                                          row.ItemArray[3].ToString(),
                                                          int.Parse(row.ItemArray[4].ToString()),
                                                          int.Parse(row.ItemArray[5].ToString()));
                        emp.CalcularSalarioAnual();
                        ListaEmpleado.Add(emp);
                    }
            }
            catch (Exception ex)
            {
                ListaEmpleado = null;
            }
            return ListaEmpleado;
        }







    }
}
