using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Mariposario {
    //Parte de la clase conexión que se encarga de la interacción de las colecciones y la base de datos
    public partial class Conexion{
        #region Obtener Colecciones
        //Método que obtiene las colecciones existentes de la base de datos.
        public List<Coleccion> obtenerColecciones() {
            List<Coleccion> colecciones = new List<Coleccion>();

            SqlCommand cmd = new SqlCommand("dbo.SelectColeccion", this.conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try {
                this.conexion.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                while(rdr.Read()) {
                    Coleccionista d = obtenerDueñoColeccion(rdr.GetString(4));
                    Coleccion c = new Coleccion(rdr.GetString(0).Trim(), rdr.GetString(1).Trim(), rdr.GetDecimal(2), rdr.GetDateTime(3),new List<MariposaDeColeccion>(),null);
                    d.Coleccion=c; c.Dueño=d;
                    colecciones.Add(c);
                }

                this.conexion.Close();
            } catch { this.conexion.Close(); return null; }
            return colecciones;
        }

        /*Función que retorna el dueño de una colección. 
        Resive como parametro el identificador de la persona obtenido de la tabla colecciones en la base de datos*/
        private Coleccionista obtenerDueñoColeccion(String id) {
            SqlConnection conn = new SqlConnection(this.cadenaConexion);
            SqlCommand cmd = new SqlCommand("seleccionar_Persona_Por_Id", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", System.Data.SqlDbType.NChar, 10);
            cmd.Parameters["@id"].Value=id;
            Coleccionista dueño=null;
            try {
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if(rdr.Read()) dueño = new Coleccionista(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2));
                conn.Close();
            } catch { conn.Close(); return null; }
            return dueño;
        }

        //Función que retorna la lista de mariposas que pertenecen a una colección especifica obteniendolas de la base de datos.
        //Recibe como parámetro el identificador de la colección a la que pertenece la mariposa.
        private List<MariposaDeColeccion> obtenerMariposasEnColeccion(String id, List<Mariposa> mariposas) {
            List<MariposaDeColeccion> mariposasColeccion = new List<MariposaDeColeccion>();
            foreach(Mariposa m in mariposas) {
                MariposaDeColeccion mar = m as MariposaDeColeccion;
                if(mar!=null && mar.Identificador==id)
                    mariposasColeccion.Add(mar);
            }
            return mariposasColeccion;
        }
        #endregion

        #region Insertar Colección
        //Función para insertar una colección. 
        //Resive como parámetro el id de la colección, el nombre de la colección, el precio (decimal),
        //El id de la persona (de tipo Biologo o Persona) ya existente en el sistema que será el dueño y las colecciones actuales
        public bool insertarColeccion(String id, String nombre, decimal precio, DateTime fecha,Persona dueño, List<Coleccion> colecciones) {
            foreach(Coleccion c in colecciones) 
                if(c.Identificador==id) return false;
                
            SqlCommand cmd1 = new SqlCommand("dbo.insertarColeccion", this.conexion);
            cmd1.CommandType = System.Data.CommandType.StoredProcedure;
            
            cmd1.Parameters.AddWithValue("@id",id);
            cmd1.Parameters.AddWithValue("@nombre_coleccion", nombre);
            cmd1.Parameters.AddWithValue("@precio", precio);
            cmd1.Parameters.AddWithValue("@fecha",fecha.ToShortDateString());
            cmd1.Parameters.AddWithValue("@id_persona", dueño.Identificador);
             
            try {
                this.conexion.Open();
                cmd1.ExecuteNonQuery();
                this.conexion.Close();
                return true;
           } catch { this.conexion.Close(); return false; }

        }
        #endregion

        #region Eliminar Colección
        //Función que elimina una colección de la base de datos y hace las actualizaciones correspondientes.
        //Recibe como paremetro la colección a ser eliminada.
        public bool eliminarColeccion(Coleccion c) {
            SqlCommand cmd1 = new SqlCommand("dbo.eliminarColeccion", this.conexion);
            cmd1.CommandType = System.Data.CommandType.StoredProcedure;
            
            cmd1.Parameters.AddWithValue("@id", c.Identificador);
            cmd1.Parameters.AddWithValue("@id_persona", c.Dueño.Identificador);
           // try {
                this.conexion.Open();
                cmd1.ExecuteNonQuery();
                this.conexion.Close();
                return true;
            //} catch { this.conexion.Close(); return false; }
        }
        #endregion

        #region Actualizar Colección
        //Función que actualiza una colección en la base de datos.
        //Recibe como parametros la colección a actualizar y la lista de mariposas que van a insertarse en la tabla mariposas_en_observacion
        public bool actualizarColeccion(Coleccion c) {
            SqlCommand cmd1 = new SqlCommand("actualizarColeccion", this.conexion);
            cmd1.CommandType = System.Data.CommandType.StoredProcedure;
           
            cmd1.Parameters.AddWithValue("@id", c.Identificador);
            cmd1.Parameters.AddWithValue("@nombre", c.Nombre);
            cmd1.Parameters.AddWithValue("@precio", c.Precio);
            cmd1.Parameters.AddWithValue("@fecha", c.FechaInicio.ToShortDateString());
            cmd1.Parameters.AddWithValue("@id_persona", c.Dueño.Identificador);
            try {
                this.conexion.Open();
                cmd1.ExecuteNonQuery();
                this.conexion.Close();
                foreach(MariposaDeColeccion m in c.Mariposas){
                    SqlCommand cmd2 = new SqlCommand("dbo.insertarMariposaDeColeccion", this.conexion);
                    cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@id", m.Identificador);
                    cmd2.Parameters.AddWithValue("@precio", m.Precio);
                    cmd2.Parameters.AddWithValue("@id_coleccion", m.Coleccion.Identificador);
                    this.conexion.Open();
                    cmd2.ExecuteNonQuery();
                    this.conexion.Close();
                }

                return true;
            } catch { this.conexion.Close(); return false; }
        }
        #endregion

    }
}
