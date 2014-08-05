using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariposario{
    // Clase que encapsula la información de una colección que pertenece a un coleccionista.
    public class Coleccion{
        
        #region Propiedades
        private Decimal precio;
        public String Identificador {set;get;}
        public String Nombre { set; get; }
        public Decimal Precio {
            set { 
                if(value > 0)this.precio = value; 
                else this.precio = 0; 
            }
            get { return precio; }
        }

        public DateTime FechaInicio { set; get; }  

        public List<MariposaDeColeccion> Mariposas { set; get; }
        public Coleccionista Dueño { set; get; }
        #endregion

        #region Constructores
        public Coleccion(){ }

        public Coleccion(String id) { this.Identificador = id; }

        public Coleccion(String id, String nombre, Decimal precio, DateTime fecha, List<MariposaDeColeccion> mariposas, Coleccionista dueño){
            Identificador=id; Nombre=nombre; Precio=precio;
            Mariposas=mariposas; Dueño=dueño; FechaInicio=fecha;
            
        }
        #endregion

        #region Métodos
        //Método ToString() sobreescrito para mostrar el nombre de la colección.
        public override string ToString() {return Nombre;}
        #endregion
    }
}
