using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

/*
 * Autor: Carlos Alberto Salgado
 */
namespace Mariposario
{
    public partial class Conexion
    {

        /*
         * Método que hace el mapeo de los objetos de tipo Coleccionista.
         */
        public List<Coleccionista> obtenerColeccionistas()
        {
            List<Coleccionista> coleccionistas = new List<Coleccionista>();

            SqlCommand comando = new SqlCommand("SelectColeccionistas", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            this.conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                coleccionistas.Add(new Coleccionista(lector.GetString(0), lector.GetString(1), lector.GetString(2)));
            }
            lector.Close();
            this.conexion.Close();
            return coleccionistas;
        }

        /*
         * Método que hace el mapeo de los objetos de tipo Biologo.
         */
        public List<Biologo> obtenerBiologos()
        {
            List<Biologo> biologos = new List<Biologo>();

            SqlCommand comando = new SqlCommand("SelectBiologos", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            this.conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                biologos.Add(new Biologo(lector.GetString(0), lector.GetString(1), lector.GetString(2), new List<Mariposa>()));
            }
            lector.Close();
            this.conexion.Close();
            return biologos;
        }

        /*
         * Método para obtener las Zonas Geográficas
         */
        public List<Zona_Geografica> obtenerZonasGeografica()
        {
            List<Zona_Geografica> zonas = new List<Zona_Geografica>();

            SqlCommand comando = new SqlCommand("SelectZonaGeografica", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            this.conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                zonas.Add(new Zona_Geografica(lector.GetString(0)));
            }
            lector.Close();
            this.conexion.Close();
            return zonas;
        }

        /*
         * Método de Inserción de Persona
         */
        public Boolean insertarPersona(String id, String nombres, String apellidos, String tipo)
        {
            SqlCommand co = new SqlCommand("InsertPersona", this.conexion);
            co.CommandType = System.Data.CommandType.StoredProcedure;
            /*
             * SqlParameter se usa para crear los parametros que recibe el procedimiento especificando
             * el nombre de la variable en el procedimiento, el tipo y su longitud; al mimos tiempo
             * se añada al objeto SqlCommand y antes de realizar la ejecución del procedimiento
             * se le asignan los valores respectivos a los parametros.
             */
            SqlParameter identificador = co.Parameters.Add("@id", System.Data.SqlDbType.NChar, 10);
            identificador.Direction = System.Data.ParameterDirection.Input;
           
            SqlParameter nombresDB = co.Parameters.Add("@nombres", System.Data.SqlDbType.NVarChar, 50);
            nombresDB.Direction = System.Data.ParameterDirection.Input;
            
            SqlParameter apellidosDB = co.Parameters.Add("@apellidos", System.Data.SqlDbType.NVarChar, 50);
            apellidosDB.Direction = System.Data.ParameterDirection.Input;
            
            SqlParameter tipoDB = co.Parameters.Add("@tipo", System.Data.SqlDbType.NVarChar, 1);
            apellidosDB.Direction = System.Data.ParameterDirection.Input;

            tipoDB.Value = tipo;
            identificador.Value = id;
            nombresDB.Value = nombres;
            apellidosDB.Value = apellidos;
            conexion.Open();
            try
            {
                co.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        /*
         * Método de Eliminación de Persona
         */
        public Boolean eliminarPersona(String id)
        {
            SqlCommand co = new SqlCommand("DeletePersona", this.conexion);
            co.CommandType = System.Data.CommandType.StoredProcedure;
            /*
             * SqlParameter se usa para crear los parametros que recibe el procedimiento especificando
             * el nombre de la variable en el procedimiento, el tipo y su longitud; al mimos tiempo
             * se añada al objeto SqlCommand y antes de realizar la ejecución del procedimiento
             * se le asignan los valores respectivos a los parametros.
             */
            SqlParameter identificador = co.Parameters.Add("@id", System.Data.SqlDbType.NChar, 10);
            identificador.Direction = System.Data.ParameterDirection.Input;

            identificador.Value = id;
            conexion.Open();
            try
            {
                co.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        /*
         * Método de Actualizacion de Persona
        */
        public Boolean modificarPersona(String idViejo, String idNuevo, String nombres, String apellidos, String tipo)
        {
            SqlCommand co = new SqlCommand("UpdatePersona", this.conexion);
            co.CommandType = System.Data.CommandType.StoredProcedure;
            /*
             * SqlParameter se usa para crear los parametros que recibe el procedimiento especificando
             * el nombre de la variable en el procedimiento, el tipo y su longitud; al mimos tiempo
             * se añada al objeto SqlCommand y antes de realizar la ejecución del procedimiento
             * se le asignan los valores respectivos a los parametros.
             */
            SqlParameter identificadorViejo = co.Parameters.Add("@idViejo", System.Data.SqlDbType.NChar, 10);
            identificadorViejo.Direction = System.Data.ParameterDirection.Input;
            SqlParameter identificadorNuevo = co.Parameters.Add("@idNuevo", System.Data.SqlDbType.NChar, 10);
            identificadorViejo.Direction = System.Data.ParameterDirection.Input;
            SqlParameter nombresDB = co.Parameters.Add("@nombres", System.Data.SqlDbType.NVarChar, 50);
            nombresDB.Direction = System.Data.ParameterDirection.Input;
            SqlParameter apellidosDB = co.Parameters.Add("@apellidos", System.Data.SqlDbType.NVarChar, 50);
            apellidosDB.Direction = System.Data.ParameterDirection.Input;
            SqlParameter tipoDB = co.Parameters.Add("@tipo", System.Data.SqlDbType.NVarChar, 1);
            apellidosDB.Direction = System.Data.ParameterDirection.Input;

            tipoDB.Value = tipo;
            identificadorViejo.Value = idViejo;
            identificadorNuevo.Value = idNuevo;
            nombresDB.Value = nombres;
            apellidosDB.Value = apellidos;
            conexion.Open();
            try
            {
                co.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        /*
        * Método de Inserción de Zona
        */
        public Boolean insertarZonaGeografica(String nombre)
        {
            SqlCommand co = new SqlCommand("InsertZonaGeografica", this.conexion);
            co.CommandType = System.Data.CommandType.StoredProcedure;
            /*
             * SqlParameter se usa para crear los parametros que recibe el procedimiento especificando
             * el nombre de la variable en el procedimiento, el tipo y su longitud; al mimos tiempo
             * se añada al objeto SqlCommand y antes de realizar la ejecución del procedimiento
             * se le asignan los valores respectivos a los parametros.
             */
            SqlParameter nombreDB = co.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar, 50);
            nombreDB.Direction = System.Data.ParameterDirection.Input;

            nombreDB.Value = nombre;

            conexion.Open();
            try
            {
                co.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        /*
         * Método de Eliminación de Zona
         */
        public Boolean eliminarZonaGeografica(String nombre)
        {
            SqlCommand co = new SqlCommand("DeleteZonaGeografica", this.conexion);
            co.CommandType = System.Data.CommandType.StoredProcedure;
            /*
             * SqlParameter se usa para crear los parametros que recibe el procedimiento especificando
             * el nombre de la variable en el procedimiento, el tipo y su longitud; al mimos tiempo
             * se añada al objeto SqlCommand y antes de realizar la ejecución del procedimiento
             * se le asignan los valores respectivos a los parametros.
             */
            SqlParameter nombreDB = co.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar, 50);
            nombreDB.Direction = System.Data.ParameterDirection.Input;

            nombreDB.Value = nombre;
            conexion.Open();
            try
            {
                co.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        /*
         * Método de Actualizacion de Zona
        */
        public Boolean modificarZonaGeografica(String nombreViejo, String nombreNuevo)
        {
            SqlCommand co = new SqlCommand("UpdateZonaGeografica", this.conexion);
            co.CommandType = System.Data.CommandType.StoredProcedure;
            /*
             * SqlParameter se usa para crear los parametros que recibe el procedimiento especificando
             * el nombre de la variable en el procedimiento, el tipo y su longitud; al mimos tiempo
             * se añada al objeto SqlCommand y antes de realizar la ejecución del procedimiento
             * se le asignan los valores respectivos a los parametros.
             */
            SqlParameter nombreViejoDB = co.Parameters.Add("@nombreViejo", System.Data.SqlDbType.NChar, 10);
            nombreViejoDB.Direction = System.Data.ParameterDirection.Input;
            SqlParameter nombreNuevoDB = co.Parameters.Add("@nombreNuevo", System.Data.SqlDbType.NChar, 10);
            nombreNuevoDB.Direction = System.Data.ParameterDirection.Input;

            nombreViejoDB.Value = nombreViejo;
            nombreNuevoDB.Value = nombreNuevo;
            conexion.Open();
            try
            {
                co.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        public List<String> obtenerEspeciesZonasGeograficas()
        {
            List<String> especiesZonasGeograficas = new List<String>();

            SqlCommand comando = new SqlCommand("SelectEspecieZonaGeografica", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            this.conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                //Inserta un String con formato "Id_Especie;Nombre_Zona;Nombre_Común"
                especiesZonasGeograficas.Add(lector.GetString(0)+";"+lector.GetString(1)+";"+lector.GetString(2));
            }
            lector.Close();
            this.conexion.Close();
            return especiesZonasGeograficas;
        }
    }
}
