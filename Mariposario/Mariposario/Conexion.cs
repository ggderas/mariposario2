using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
    }
}
