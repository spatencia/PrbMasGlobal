using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Conexion
{
    public class Connection
    {

        string ConnectionString = "Data Source=(local)\\SQLEXPRESS; Initial Catalog=MasGlobal; Integrated Security=False; User Id=usermasglobal;Password=usermasglobal; MultipleActiveResultSets=True";
        SqlConnection con;

        public void OpenConection()
        {
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Para insertar, Actualizar o Eliminar
        /// </summary>
        /// <param name="Query_"></param>
        public bool ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }

        /// <summary>
        /// Para los comandos Select
        /// </summary>
        /// <param name="Query_"></param>
        /// <returns></returns>
        public SqlDataReader DataReader(string Query_)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(Query_, con);
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Retornar en una tabla el resultado de la consulta (SELECT)
        /// </summary>
        /// <param name="Query_"></param>
        /// <returns></returns>
        public DataTable ShowDataTable(string Query_)
        {
            try
            {
                SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
                DataSet ds = new DataSet();
                dr.Fill(ds);
                DataTable dataum = ds.Tables[0];
                return dataum;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
