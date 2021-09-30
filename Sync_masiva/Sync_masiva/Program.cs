using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sync_masiva
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection cnn = Base_de_datos.Conexionbd.DbConnection.getDBConnection();

                DataSet ds = new DataSet();
                string Csql = "Ecomm_Syncproductos";
                SqlDataAdapter da = new SqlDataAdapter(Csql, cnn);
                da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                da.Fill(ds, "Csql");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro el script a ejecutar");
            }
        }
    }
}
