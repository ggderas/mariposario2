using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
/*
 * Clase que tiene como objetivo mantener la comunicación
 * entre la aplicación y la base de datos.
 */

namespace Mariposario
{
    public partial class Conexion
    {
        private String cadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=MariposarioDB;Integrated Security=True";
        private SqlConnection conexion;

        public Conexion()
        {
            this.conexion = new SqlConnection(this.cadenaConexion);
        }

        #region Consultas
        //Función para crear las consultas 5 y 6. 
        //Recibe como parametro una cadena que es el nombre del procedimiento almacenado.
        public DataTable consulta(String consulta) {
            SqlCommand comando = new SqlCommand(consulta, this.conexion);
            comando.CommandType = CommandType.StoredProcedure;
            this.conexion.Open();
            SqlDataReader lector = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(lector);
            this.conexion.Close();
            return tabla;
        }
        #endregion
    }
}
