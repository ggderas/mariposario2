using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Mariposario
{
    #region Autor: Cindy Carolina Alonzo
    #endregion

    public partial class Conexion
    {
        #region Obtener una familia en especifico

        public FamiliaNatural obtenerFamiliaNatural(String nombre) {
            FamiliaNatural familia = new FamiliaNatural("","");
            SqlCommand comando = new SqlCommand("seleccionarFamiliaEspecifica", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            
            this.conexion.Open();

            try
            {
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    familia = new FamiliaNatural(lector.GetString(0), lector.GetString(1));
                }
                conexion.Close();
                return familia;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return null;
            }
        }
        #endregion

        #region obtener especie especifica
        public Especie obtenerEspecieEspecifica(String nombre_cientifico)
        {
            Especie especie = new Especie("");
            SqlCommand comando = new SqlCommand("seleccionarEspecieEspecifica", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre_cientifico", nombre_cientifico);

            this.conexion.Open();

            try
            {
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    especie = new Especie(lector.GetString(0));
                }
                conexion.Close();
                return especie;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return null;
            }
        }

        #endregion

        #region obtener genero especifico
        public Genero obtenerGeneroEspecifico(String id, String nombre_genero)
        {
            Genero genero = new Genero("","");
            SqlCommand comando = new SqlCommand("seleccionarEspecieEspecifica", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre_genero", nombre_genero);
            comando.Parameters.AddWithValue("@id", id);

            this.conexion.Open();

            try
            {
                SqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    genero = new Genero(lector.GetString(0),lector.GetString(1));
                }
                conexion.Close();
                return genero;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return null;
            }
        }
        #endregion

        #region Obtener ESPECIE
        /*
         * Método que hace el mapeo de los objetos de tipo ESPECIE.
         */

        public List<Especie> obtenerEspecie()
        {

            List<Especie> listaEspecies = new List<Especie>();
            SqlCommand comando = new SqlCommand("SelectEspecie", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            this.conexion.Open();

            DataTable tablaEspecie = new DataTable();
            SqlDataReader lector = comando.ExecuteReader();
            tablaEspecie.Load(lector);
            this.conexion.Close();

            comando = new SqlCommand("SelectGenero", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            this.conexion.Open();

            DataTable tablaGenero = new DataTable();
            lector = comando.ExecuteReader();
            tablaGenero.Load(lector);
            this.conexion.Close();
            #region Asign el genero a cada especie
            for (int i = 0; i < tablaEspecie.Rows.Count; i++)
            {
                for (int j = 0; j < tablaGenero.Rows.Count; j++)
                {
                    String id_genero = (String)tablaGenero.Rows[j][0];
                    String id_especie = (String)tablaEspecie.Rows[i][1];

                    if (id_genero.Equals(id_especie))
                    {
                        Genero genero = new Genero((String)tablaGenero.Rows[j][0], (String)tablaGenero.Rows[j][1]);
                        listaEspecies.Add(new Especie((String)tablaEspecie.Rows[i][0], genero));

                    }
                }
            }
            #endregion


            /* for ( int i = 0; i < tablaEspecie.Rows.Count;i++ ) {
                for ( int j = 0; j < listaMariposa.Count; j++) { 
                     if(listaEspecies[i].NombreCientifico.Equals(listaMariposa[j]))
                }
            }*/

            return listaEspecies;
        }
        #endregion

        #region Obtener GENERO
        /*
         * Método que hace el mapeo de los objetos de tipo GENERO.
         */
        public List<Genero> obtenerGeneros()
        {
            List<Genero> listaGeneros = new List<Genero>();
            SqlCommand comando = new SqlCommand("SelectFamiliaNatural", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            this.conexion.Open();

            DataTable tablaFamiliaNatural = new DataTable();
            SqlDataReader lector = comando.ExecuteReader();
            tablaFamiliaNatural.Load(lector);
            this.conexion.Close();

            comando = new SqlCommand("SelectGenero", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            this.conexion.Open();
            DataTable tablaGenero = new DataTable();
            lector = comando.ExecuteReader();
            tablaGenero.Load(lector);

            this.conexion.Close();

            for (int i = 0; i < tablaGenero.Rows.Count; i++)
            {
                for (int j = 0; j < tablaFamiliaNatural.Rows.Count; j++)
                {
                    string idFamiliaGenero = (String)tablaGenero.Rows[i][2];
                    string idFamiliaNatural = (String)tablaFamiliaNatural.Rows[j][0];

                    if (idFamiliaGenero.Equals(idFamiliaNatural))
                    {
                        FamiliaNatural familia = new FamiliaNatural((String)tablaFamiliaNatural.Rows[j][0], (String)tablaFamiliaNatural.Rows[j][1]);
                        listaGeneros.Add(new Genero((String)tablaGenero.Rows[i][0], (string)tablaGenero.Rows[i][1], familia));

                    }
                }
            }
            List<Especie> listaEspecies = new List<Especie>();
            listaEspecies = obtenerEspecie();

            for (int i = 0; i < listaGeneros.Count; i++)
            {
                for (int j = 0; j < listaEspecies.Count; j++)
                {
                    if (listaGeneros[i].Identificador.Equals(listaEspecies[j].Genero.Identificador))
                    {
                        listaGeneros[i].Especies.Add(listaEspecies[j]);
                    }
                }
            }
            return listaGeneros;
        }
        #endregion

        #region Obtener FamiliaNatural
        /*  * Método que hace el mapeo de los objetos de tipo FAMILIA NATURAL.*/
        public List<FamiliaNatural> obtenerFamiliaNatural()
        {
            List<FamiliaNatural> listaFamiliaNatural = new List<FamiliaNatural>();
            SqlCommand comando = new SqlCommand("SelectFamiliaNatural", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            this.conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                listaFamiliaNatural.Add(new FamiliaNatural(lector.GetString(0), lector.GetString(1)));
            }
            this.conexion.Close();
            List<Genero> listaGeneros = new List<Genero>();
            listaGeneros = obtenerGeneros();

            for (int i = 0; i < listaFamiliaNatural.Count; i++)
            {
                for (int j = 0; j < listaGeneros.Count; j++)
                {
                    if (listaFamiliaNatural[i].Nombre.Equals(listaGeneros[j].FamiliaNatural.Nombre))
                    {
                        listaFamiliaNatural[i].Generos.Add(listaGeneros[j]);
                    }
                }
            }
            return listaFamiliaNatural;

        }
        #endregion

        #region Agregar FamiliaNatural

        public Boolean insertarFamiliaNatural(String id, String nombre_familia)
        {
            SqlCommand comando = new SqlCommand("insertarFamiliaNatural", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre_familia", nombre_familia);

            try
            {
                this.conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException)
            {
                this.conexion.Close();
                return false;
            }

        }


        #endregion

        #region Agregar Genero
        public Boolean insertarGenero(String id, String nombre_genero,String id_familia)
        {
            SqlCommand comando = new SqlCommand("insertarGenero", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter identificador = comando.Parameters.Add("@id", System.Data.SqlDbType.NChar, 10);
            identificador.Direction = System.Data.ParameterDirection.Input;

            SqlParameter nombreDB = comando.Parameters.Add("@nombre_genero", System.Data.SqlDbType.NVarChar, 50);
            nombreDB.Direction = System.Data.ParameterDirection.Input;

            SqlParameter idFamiliaBD = comando.Parameters.Add("@id_familia", System.Data.SqlDbType.NChar, 10);

            identificador.Value = id;
            nombreDB.Value = nombre_genero;
            idFamiliaBD.Value = id_familia;

            try
            {
                this.conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {
                    return true;
                }
                else
                {
                    this.conexion.Close();
                    return false;
                }
            }
            catch (SqlException)
            {
                this.conexion.Close();
                return false;
            }

        }

        #endregion

        #region Agregar Especie
        public Boolean insertarEspecie(String nombre_cientifico, String id_genero)
        {
            SqlCommand comando = new SqlCommand("insertarEspecie", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre_cientifico",nombre_cientifico);
            comando.Parameters.AddWithValue("@id_genero",id_genero);
            
            try
            {
                this.conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {
                    return true;
                }
                else
                {
                    this.conexion.Close();
                    return false;
                }
            }
            catch (SqlException)
            {
                this.conexion.Close();
                return false;
            }

        }
        
        #endregion

        #region eliminar familiaNatural
        public Boolean eliminarFamiliaNatural(String identificador)
        {
            SqlCommand comando = new SqlCommand("EliminarFamiliaNatural", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            

            SqlParameter identificadorBD = comando.Parameters.Add("@identificador", System.Data.SqlDbType.NChar, 10);
            identificadorBD.Direction = System.Data.ParameterDirection.Input;

            identificadorBD.Value = identificador;
            conexion.Open();
            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }
        #endregion

        #region eliminar Genero
        public Boolean eliminarGenero(String identificador)
        {
            SqlCommand comando = new SqlCommand("EliminarGenero", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@identificador", identificador);

            conexion.Open();
            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }
        #endregion

        #region eliminar Especie
        public Boolean eliminarEspecie(String nombreCientifico)
        {
            SqlCommand comando = new SqlCommand("EliminarEspecie", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreCientifico",nombreCientifico);

            conexion.Open();
            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }
        #endregion

        #region  modificar Familia Natural
       
        public Boolean modificarFamiliaNatural(String idViejo, String idNuevo, String nombre)
        {
            SqlCommand co = new SqlCommand("actualizar_FamiliaNatural", this.conexion);
            co.CommandType = System.Data.CommandType.StoredProcedure;
            
            SqlParameter identificadorViejo = co.Parameters.Add("@idViejo", System.Data.SqlDbType.NChar, 10);
            identificadorViejo.Direction = System.Data.ParameterDirection.Input;
            SqlParameter identificadorNuevo = co.Parameters.Add("@idNuevo", System.Data.SqlDbType.NChar, 10);
            identificadorViejo.Direction = System.Data.ParameterDirection.Input;
            SqlParameter nombresDB = co.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar, 50);
            nombresDB.Direction = System.Data.ParameterDirection.Input;
            
            identificadorViejo.Value = idViejo;
            identificadorNuevo.Value = idNuevo;
            nombresDB.Value = nombre;
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

        #endregion

        #region modificar Genero
        public Boolean modificarGenero(String idViejo, String idNuevo, String nombre, String idFamilia)
        {
            SqlCommand comando = new SqlCommand("actualizarGenero", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idNuevo", idNuevo);
            comando.Parameters.AddWithValue("@idViejo", idViejo);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@idFamilia", idFamilia);
          
            conexion.Open();
            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }
        #endregion

        #region modificar Especie
        public Boolean modificarEspecie(String nombreViejo, String nombreNuevo, String id_genero)
        {
            SqlCommand comando = new SqlCommand("actualizar_especie", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreViejo", nombreViejo);
            comando.Parameters.AddWithValue("@nombreNuevo", nombreNuevo);
            comando.Parameters.AddWithValue("@id_genero", id_genero);
            
            
            conexion.Open();
            try
            {
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException sqlE)
            {
                conexion.Close();
                return false;
            }
        }

        #endregion

    }
}
