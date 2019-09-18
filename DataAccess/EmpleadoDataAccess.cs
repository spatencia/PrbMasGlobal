using DataAccess.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccess.EmpleadoDataAccess
{
    public class EmpleadoDataAccess
    {

        public static DataTable ObtenerEmpleadoByIdentificacion(string identificacion)
        {
            Connection con = new Connection();
            DataTable result = new DataTable();
            try
            {
                con.OpenConection();
                result = con.ShowDataTable("SELECT * FROM Empleado WHERE Identificacion = " + identificacion);
                con.CloseConnection();
            }
            catch (Exception)
            {
                con.CloseConnection();
                return new DataTable();
            }
            return result;
        }

        public static DataTable ObtenerTodosEmpleados()
        {
            Connection con = new Connection();
            DataTable result = new DataTable();
            try
            {
                con.OpenConection();
                result = con.ShowDataTable("SELECT * FROM Empleado");
                con.CloseConnection();
            }
            catch (Exception)
            {
                con.CloseConnection();
                return new DataTable();
            }
            return result;
        }

        public static bool InsertarEmpleado(string nombre, string apellido, int salario, int tipoContrato)
        {
            Connection con = new Connection();
            bool result = false;
            try
            {
                con.OpenConection();
                string QueryInsert = string.Format("INSERT INTO Empleado(Nombre, Apellido, Salario, TipoContrato) values ('{0}','{1}',{2},{3})", nombre, apellido, salario, tipoContrato);
                result = con.ExecuteQueries(QueryInsert);
                con.CloseConnection();
            }
            catch (Exception)
            {
                con.CloseConnection();
                result = false;
            }
            return result;
        }


    }
}
