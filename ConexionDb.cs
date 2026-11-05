using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace TareaProgramacion_Jefferson_y_Issac
{
    public class ConexionDb
    {
        private string cadenaConexion = "Server=localhost;Database=GestionProductosDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);

        }


    }
}
