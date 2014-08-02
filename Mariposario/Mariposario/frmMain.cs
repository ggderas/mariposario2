using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mariposario
{
    public partial class frmMain : Form
    {

        private List<MariposaEnObservacion> mariposasObservacion;
        private List<MariposaDeColeccion> mariposasColeccion;
        private List<Mariposa> mariposas;
        private List<Zona_Geografica> zonas_geograficas;
        private List<FamiliaNatural> familiasNaturales;
        private List<Coleccionista> coleccionistas;
        private List<Coleccion> colecciones;
        private List<Biologo> biologos;
        private List<Especie> especies;
        private List<Genero> generos;
        private Conexion conexion;

        #region Propiedades
        public List<Mariposa> Mariposas
        {
            get { return mariposas; }
        }

        public List<Zona_Geografica> Zonas_geograficas
        {
            get { return zonas_geograficas; }
        }

        public List<FamiliaNatural> FamiliasNaturales
        {
            get { return familiasNaturales; }
        }

        public List<Coleccionista> ColeccionistasL
        {
            get { return coleccionistas; }
        }

        public List<Coleccion> Colecciones
        {
            get { return colecciones; }
        }

        public List<Biologo> Biologos
        {
            get { return biologos; }
        }

        public List<Especie> Especies
        {
            get { return especies; }
        }

        public List<Genero> Generos
        {
            get { return generos; }
        }

        public List<MariposaDeColeccion> MariposasColecccion
        {
            get { return mariposasColeccion; }
        }

        public List<MariposaEnObservacion> MariposasObservacion
        {
            get { return mariposasObservacion; }
        }
        #endregion


        public frmMain()
        {
            InitializeComponent();

            this.conexion = new Conexion();

            this.mariposasObservacion = new List<MariposaEnObservacion>();
            this.mariposasColeccion = new List<MariposaDeColeccion>();


            CargarBaseDeDatos();
        }

        /*
         * Método que inicializa todas las listas de las entidades de la base de datos.
         */
        public void CargarBaseDeDatos()
        {
            this.mariposas = this.conexion.obtenerMariposas();
            this.zonas_geograficas = this.conexion.obtenerZonasGeografica();
            this.familiasNaturales = this.conexion.obtenerFamiliaNatural();
            this.coleccionistas = this.conexion.obtenerColeccionistas();
            //AQUI UN CAMBIO: conexion.obtenerColecciones recibe la lista de mariposas.
            //this.colecciones = this.conexion.obtenerColecciones();
            this.colecciones = this.conexion.obtenerColecciones(this.mariposas);
            this.biologos = this.conexion.obtenerBiologos();
            this.especies = this.conexion.obtenerEspecie();
            this.generos = this.conexion.obtenerGeneros();
            this.diferenciarMariposas();
            relacionarEntidades();
        }

        #region Eventos
        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void gpbOpciones_Enter(object sender, EventArgs e)
        {

        }

        private void Coleccionistas_MouseMove(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.Khaki;
        }

        private void Coleccionistas_Click(object sender, EventArgs e)
        {
            frmColeccionistas frmColeccionistasMain = new frmColeccionistas(this.coleccionistas, this);
            frmColeccionistasMain.ShowDialog();
        }

        private void Coleccionistas_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.LightSteelBlue;
        }

        private void btnBiologos_Click(object sender, EventArgs e)
        {
            frmBiologos frmBiologosMain = new frmBiologos(this.biologos, this);
            frmBiologosMain.ShowDialog();
        }

        private void btnMariposas_Click(object sender, EventArgs e)
        {
            formularioMariposas frmMariposasMain = new formularioMariposas(this.mariposasColeccion, this.mariposasObservacion, this.conexion,
                                                    this.familiasNaturales, this.colecciones, this.zonas_geograficas, this.biologos, this);
            frmMariposasMain.ShowDialog();
        }

        private void btnColeccionistas_Click(object sender, EventArgs e)
        {
            //formularioColecciones f = new formularioColecciones(this.colecciones, this.biologos, this.coleccionistas, this.mariposasObservacion, this.mariposasColeccion, this.conexion);
            //f.ShowDialog();
            //this.colecciones=f.colecciones;
            //this.biologos=f.personas;
            //this.coleccionistas = f.coleccionistas;
            //this.mariposasObservacion = f.mariposas;
            //this.mariposasColeccion = f.mariposasColeccion;
        }
        #endregion

        private void administrarZonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZonaGeografica frmZona = new frmZonaGeografica(this.zonas_geograficas, this);
            frmZona.ShowDialog();
            this.zonas_geograficas = this.conexion.obtenerZonasGeografica();
        }


        private void diferenciarMariposas()
        {
            mariposasColeccion = new List<MariposaDeColeccion>();
            mariposasObservacion = new List<MariposaEnObservacion>();

            foreach (Mariposa mariposa in mariposas)
            {
                #region Asociación Mariposa-Especie
                foreach (Especie especie in especies)
                {
                    if (especie.NombreCientifico.Equals(mariposa.Especie.NombreCientifico.Trim()))
                    {
                        mariposa.Especie = especie;
                        especie.listaMariposas.Add(mariposa);
                        break;
                    }
                }
                #endregion

                #region Asociación Mariposa-Zona Geografica
                foreach(Zona_Geografica zona in zonas_geograficas)
                {
                    if (mariposa.Zona.NombreZona.Trim().Equals(zona.NombreZona.Trim()))
                    {
                        mariposa.Zona = zona;
                        zona.ListaDeMariposas.Add(mariposa);
                        break;
                    }
                }
                #endregion

                try
                {
                    MariposaDeColeccion mCole = (MariposaDeColeccion)mariposa;
                    mariposasColeccion.Add(mCole);
                }
                catch (InvalidCastException) { }
                try
                {
                    MariposaEnObservacion mObs = (MariposaEnObservacion)mariposa;
                    mariposasObservacion.Add(mObs);
                }
                catch (InvalidCastException) { }
            }
        }

        /*
         * Método que relaciona los objetos de las listas tal
         * como se encuentran en la BD.
         */
        private void relacionarEntidades()
        {
            #region Asociación Colecciones-Coleccionistas

            foreach (Coleccion coleccion in colecciones)
            {
                foreach (Coleccionista coleccionista in coleccionistas)
                {
                    if (coleccion.Dueño.Identificador.Trim().Equals(coleccionista.Identificador.Trim()))
                    {
                        coleccion.Dueño = coleccionista;
                        coleccionista.Coleccion = coleccion;
                        break;
                    }
                }
            }
            #endregion

            #region Clasificación de Mariposas y Asociación a Colección Y Biologos
            foreach (MariposaDeColeccion mariposaC in mariposasColeccion)
            {
                foreach (Coleccion coleccion in colecciones)
                {
                    if (mariposaC.Coleccion.Identificador.Trim().Equals(coleccion.Identificador.Trim()))
                    {
                        coleccion.Mariposas.Add(mariposaC);
                        mariposaC.Coleccion = coleccion;
                        break;
                    }
                }

                foreach (Biologo biologo in biologos)
                {
                    if (mariposaC.Biologo.Identificador.Trim().Equals(biologo.Identificador.Trim()))
                    {
                        mariposaC.Biologo = biologo;
                        biologo.ListaDeMariposasEnObservacion.Add(mariposaC);
                        break;
                    }
                }
            }

            foreach (MariposaEnObservacion mariposaO in mariposasObservacion)
            {
                foreach (Biologo biologo in biologos)
                {
                    if (mariposaO.Biologo.Identificador.Trim().Equals(biologo.Identificador.Trim()))
                    {
                        mariposaO.Biologo = biologo;
                        biologo.ListaDeMariposasEnObservacion.Add(mariposaO);
                        break;
                    }
                }
            }
            #endregion

            #region Asociación Zona Geográfica-Especie

            #region Obtencion Especies_ZonaGeografica para obtener nombre común
            List<String> especie_zonas = conexion.obtenerEspeciesZonasGeograficas();
            List<String[]> lista_especies_zonas_separados = new List<String[]>();
            foreach (String cadena_especie_zona in especie_zonas)
            {
                lista_especies_zonas_separados.Add(cadena_especie_zona.Split(';'));
            }
            #endregion

            foreach (Especie especie in especies)
            {
                foreach (Zona_Geografica zona in zonas_geograficas)
                {
                    foreach (String[] especie_zona in lista_especies_zonas_separados)
                    {
                        //String con formato "Id_Especie;Nombre_Zona;Nombre_Común"
                        if (especie.NombreCientifico.Trim().Equals(especie_zona[0].Trim()) &&
                            zona.NombreZona.Trim().Equals(especie_zona[1].Trim()))
                        {
                            //String con formato "Nombre_Zona;Nombre_Comun"
                            especie.NombreComun_Zona.Add(especie_zona[1].Trim() + ";" + especie_zona[2].Trim());
                            especie.listaZonaGeografica.Add(zona);
                            zona.Especies_Zona.Add(especie);    
                        }
                    }
                }
            }

            #endregion

            #region Asociación Genero-Familia Natural
            foreach (FamiliaNatural familia in familiasNaturales)
            {
                foreach (Genero genero in generos)
                {
                    if (genero.FamiliaNatural.Identificador.Trim().Equals(familia.Identificador.Trim()))
                    {
                        genero.FamiliaNatural = familia;
                        //verifica si el genero ya existe en la lista de generos de familia,
                        //si no existe lo agrega;
                        if (!familia.Generos.Contains(genero))
                        {
                            familia.Generos.Add(genero);
                        }
                    }
                }
            }
            #endregion

            #region Asociación Especie-Genero
            foreach (Genero genero in generos)
            {
                foreach (Especie especie in especies)
                {
                    if (especie.Genero.Identificador.Trim().Equals(genero.Identificador.Trim()))
                    {
                        especie.Genero = genero;
                        //verifica si la lista ya existe en la lista de especies de genero,
                        //si no existe lo agrega;
                        if (!genero.Especies.Contains(especie))
                        {
                            genero.Especies.Add(especie);
                        }
                    }
                }
            }
            #endregion

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultas formulario = new frmConsultas(this.conexion);
            formulario.ShowDialog();
        }
    }
}
