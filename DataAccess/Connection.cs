using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Conexion
{
    public class Connection
    {
        string ConnectionString = "Data Source=10.231.50.69; Initial Catalog=SPA; Integrated Security=False; User Id=Kmendoza;Password=kmendoza2018; MultipleActiveResultSets=True";
        SqlConnection con;

        public void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }

        public void CloseConnection()
        {
            con.Close();
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
