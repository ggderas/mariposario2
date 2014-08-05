using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
/*
 * Autor: Luis Manuel Deras
 */

namespace Mariposario
{
    public partial class Conexion
    {
        #region Obtener las mariposas

        /*
         * Método que hace el mapeo de los objetos de tipo mariposa.
         */
        public List<Mariposa> obtenerMariposas()
        {
            List<Mariposa> mariposas = new List<Mariposa>();

            SqlCommand comando = new SqlCommand("seleccionar_Mariposa", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            this.conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Boolean haSidoLiberado = lector.GetBoolean(6);

                String nombreCientifico = lector.GetString(2);
                String identificadorBiologo = lector.GetString(4);
                String nombreZona = lector.GetString(5);

                mariposas.Add(new Mariposa(lector.GetString(0), lector.GetDateTime(1), nombreCientifico,
                             identificadorBiologo, nombreZona, haSidoLiberado));
            }

            this.conexion.Close();

            diferenciarMariposas(mariposas);

            return mariposas;
        }

        #endregion

        #region Diferencias los tipos de mariposas

        /*
         * Método que a partir de las mariposas que no se han distinguido,
         * logra la diferenciación de éstas. Aquí se especializan las 
         * mariposas. Ya sean de observación o de colección
         */
        private void diferenciarMariposas(List<Mariposa> mariposas)
        {
            SqlCommand comando = new SqlCommand("seleccionar_Mariposa_en_Coleccion", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            this.conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                MariposaDeColeccion mariposaDeColeccion = new MariposaDeColeccion();
                Mariposa mariposaEliminar = new Mariposa();

                //String tipoMariposa = lector.GetString(3);
                String identificador = lector.GetString(0);

                foreach (Mariposa mariposa in mariposas)
                {
                    if (mariposa.Identificador.Equals(identificador))
                    {
                        //Modificado ya que en la base es de tipo Decimal, y Decimal no es compatible ni 
                        //equivalente a float.
                        float precio = float.Parse(Convert.ToString(lector.GetDecimal(1)));
                        String idColeccion = lector.GetString(2);

                        mariposaDeColeccion =
                            new MariposaDeColeccion(mariposa.Identificador, mariposa.FechaDeCaptura, precio, mariposa.Especie.NombreCientifico,
                                                mariposa.Biologo.Identificador, mariposa.Zona.NombreZona, idColeccion, mariposa.Liberado);

                        mariposaEliminar = mariposa;

                        break;
                    }
                }

                mariposas.Remove(mariposaEliminar); //Elimina la referencia de la mariposa que no se sabe su distinción.
                mariposas.Add(mariposaDeColeccion);
            }

            //Modificado dado Excpetion
            this.conexion.Close();

            comando = new SqlCommand("seleccionar_Mariposa_en_Observacion", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            this.conexion.Open();

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                MariposaEnObservacion mariposaEnObservacion = new MariposaEnObservacion();
                Mariposa mariposaEliminar = new Mariposa();

                //String tipoMariposa = lector.GetString(3);
                String identificador = lector.GetString(0);

                foreach (Mariposa mariposa in mariposas)
                {
                    if (mariposa.Identificador.Equals(identificador))
                    {
                        Decimal tiempoDeObservacion = lector.GetDecimal(1);

                        mariposaEnObservacion =
                            new MariposaEnObservacion(mariposa.Identificador, mariposa.FechaDeCaptura, tiempoDeObservacion, mariposa.Especie.NombreCientifico,
                                                      mariposa.Biologo.Identificador, mariposa.Zona.NombreZona, mariposa.Liberado);

                        mariposaEliminar = mariposa;

                        break;
                    }
                }

                mariposas.Remove(mariposaEliminar); //Elimina la referencia de la mariposa que no se sabe su distinción.
                mariposas.Add(mariposaEnObservacion);
            }

            this.conexion.Close();

        }

        #endregion

        #region Agregar Mariposa

        public Boolean agregarMariposa(String idMariposa, DateTime fechaCaptura, String nombreCientifico, Char tipo,
                                    String idBiologo, String zonaGeografica, decimal tiempoObservacion, decimal precio,
                                    String idColeccion)
        {
            SqlCommand comando = new SqlCommand("insertarMariposa", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idMariposa", idMariposa);
            comando.Parameters.AddWithValue("@fechaCaptura", fechaCaptura);
            comando.Parameters.AddWithValue("@nombreCientifico", nombreCientifico);

            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Parameters.AddWithValue("@idPersona", idBiologo);
            comando.Parameters.AddWithValue("@zonaGeografica", zonaGeografica);

            comando.Parameters.AddWithValue("@tiempoObservacion", tiempoObservacion);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@idColeccion", idColeccion);

            try
            {
                this.conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 2)
                {
                    this.conexion.Close();
                    return true;
                }
                else
                {
                    this.conexion.Close();
                    return false;
                }
            } catch(SqlException) {
                this.conexion.Close();
                return false;
            }

        }

        #endregion

        #region Eliminar mariposa

        public Boolean eliminarMariposa(String idMariposa)
        {
            try
            {
                SqlCommand comando = new SqlCommand("eliminarMariposa", this.conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idMariposa", idMariposa);

                this.conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 1)
                {
                    this.conexion.Close();
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

        #region Actualizar mariposa

        public Boolean actualizarMariposa(String idMariposa, DateTime fechaCaptura, String nombreCientifico, char tipo,
                                        String idPersona, String zonaGeografica, decimal tiempoDeObservacion, decimal precio,
                                       String idColeccion)
        {
            SqlCommand comando = new SqlCommand("actualizarMariposa", this.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                comando.Parameters.AddWithValue("@idMariposa", idMariposa);
                comando.Parameters.AddWithValue("@fechaCaptura", fechaCaptura);

                comando.Parameters.AddWithValue("@nombreCientifico", nombreCientifico);
                comando.Parameters.AddWithValue("@tipo", tipo);

                comando.Parameters.AddWithValue("@idPersona", idPersona);
                comando.Parameters.AddWithValue("@zonaGeografica", zonaGeografica);

                comando.Parameters.AddWithValue("@tiempoObservacion", tiempoDeObservacion);
                comando.Parameters.AddWithValue("@precio", precio);

                comando.Parameters.AddWithValue("@idColeccion", idColeccion);

                this.conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 2)
                {
                    this.conexion.Close();
                    return true;
                }
                else
                {
                    this.conexion.Close();
                    return false;
                }

            }
            catch (SqlException sql)
            {
                this.conexion.Close();
                throw sql;
            }

        }

        #endregion

        #region Consulta 1

        public DataTable consulta1()
        {
            SqlCommand comando = new SqlCommand("consulta1", this.conexion);
            comando.CommandType = CommandType.StoredProcedure;

            this.conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(lector);

            this.conexion.Close();

            return tabla;
        }

        #endregion

        #region Consulta2

        public DataTable consulta2()
        {
            SqlCommand comando = new SqlCommand("consulta2", this.conexion);
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
