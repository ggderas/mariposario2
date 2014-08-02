using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mariposario {
    //Parte de la clase conexión que se encarga de la interacción de las colecciones y la base de datos
    public partial class Conexion{
        #region Obtener Colecciones
        //Método que obtiene las colecciones existentes de la base de datos.
        public List<Coleccion> obtenerColecciones() {
            List<Coleccion> colecciones = new List<Coleccion>();

            SqlCommand cmd = new SqlCommand("dbo.SelectColeccion", this.conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            this.conexion.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read()) {
                //Coleccionista d = obtenerDueñoColeccion(rdr.GetString(3));
                //List<MariposaDeColeccion> m = obtenerMariposasEnColeccion(rdr.GetString(0));
                Coleccion c = new Coleccion(rdr.GetString(0), rdr.GetString(1), rdr.GetDecimal(2), new List<MariposaDeColeccion>(), new Coleccionista(rdr.GetString(3)," "," "));
                //d.Coleccion=c; c.Dueño=d;
                colecciones.Add(c);
            }

            this.conexion.Close();

            return colecciones;
        }

        //Función que retorna el dueño de una colección. 
        //Resive como parametro el identificador de la persona obtenido de la tabla colecciones en la base de datos
        //private Coleccionista obtenerDueñoColeccion(String id) {
        //    SqlConnection conn = new SqlConnection(this.cadenaConexion);
        //    SqlCommand cmd = new SqlCommand("select * from Persona where id='"+id+"'", this.conexion);
        //    conn.Open();
        //    SqlDataReader rdr = cmd.ExecuteReader();
        //    Coleccionista dueño = new Coleccionista(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), null);
        //    conn.Close();
        //    return dueño;
        //}

        //Función que retorna la lista de mariposas que pertenecen a una colección especifica obteniendolas de la base de datos.
        //Recibe como parámetro el identificador de la colección a la que pertenece la mariposa.
        private List<MariposaDeColeccion> obtenerMariposasEnColeccion(String id) {
            List<Mariposa> mariposas = this.obtenerMariposas();
            List<MariposaDeColeccion> mariposasColeccion = new List<MariposaDeColeccion>();
            foreach(Mariposa m in mariposas) {
                MariposaDeColeccion mar = m as MariposaDeColeccion;
                if(mar!=null && mar.Identificador==id)
                    mariposasColeccion.Add(mar);
            }
            return mariposasColeccion;
        }
        #endregion
    }
}
