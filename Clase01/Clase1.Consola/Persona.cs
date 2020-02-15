using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Consola
{
   public class Persona
    {
        //string nombre;
        //int edad;

      

        //public Persona() // constructor sin carga de informacion
        //{
        //}
        
        //public Persona(string nombre, int edad) // constructor sobrecargado
        //{
        //    this.nombre = nombre;
        //    this.edad = edad;
        //}
        //public void imprimirDatos() {

        //    Console.WriteLine(nombre+ " ", +edad);
        
        //}
           
        /* metodos abreviado prop y profull 
         - atributo : son las variables para acceder a las propiedades
         - propiedad: son los atributos de la clase, es decir los estados    
             
             
             
             */
        
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public Persona()
        {
        }
    }
  


}

