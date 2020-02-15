using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            ///* Array ( Matrices o Arreglos)
            //Estructuras que contienen valores del mismo tipo (int , string, double, etc)

            // */
            // // declaracionn inicial
            // int[] miMatriz;
            //// Iniciacion 

            //miMatriz = new int[4];
            //// declarar e inicializar 

            //int[] miMatriz2 = new int[4];

            #region Arreglos
            //// Agregar informacion en arreglo
            ////MODO 1
            //miMatriz[0] = 2;
            //miMatriz[1] = 10;
            //miMatriz[2] = 3;
            //miMatriz[3] = 15;
            ////MODO 2

            //int[] arrayNumeros ={ 2,10,3, 15};

            //Console.WriteLine("Recorrido con FOR");

            //for (int i = 0; i < arrayNumeros.Count(); i++)
            //{
            //   Console.WriteLine(arrayNumeros[i]);

            //}

            //Console.WriteLine("Recorrido con FOREACH");

            //foreach (var item in arrayNumeros)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Arreglos con Clase y manejo de errores
            // try
            // {

            //Persona Ana = new Persona("Ana",22);


            // Persona[] persona = new Persona[2];

            // persona[0] = new Persona("Luis",22);
            // persona[1] = Ana;

            // for (int i = 0; i < persona.Length; i++)
            // {
            //     persona[i].imprimirDatos();
            // }
            // persona[3].imprimirDatos(); // forzar a un error 
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine("Se presento un error");

            // }

            #endregion

            #region Listas (Coleccion de datos)
            /*
             - permite almacenar elemento genericos
             - no tiene limitaciones como los Arrays, pero genera mayor consumo de recursos
             - se puede realizar las operaciones ordenar, buscar, añadir
             */


            // Arregar datps en la lista mediante el metodo Add

            //  for (int i = 0; i < arrayNumeros.Length; i++)

            //{
            //      listaDatos.Add(arrayNumeros[i]);


            //  }
            //  //mostrar datos de un list

            //  for (int i = 0; i < listaDatos.Count; i++)
            //  {
            //      Console.WriteLine(listaDatos[i]);
            //  }

            /* 
             elaborar un programa donde inngrese los valores, si es cero termina su ejecucion
          //   */
            //string campo;  
            //  List<string> listaDatos = new List<string>();
            //  do
            //  {
            //       Console.WriteLine("Ingrese informacion: ");

            //              campo= Console.ReadLine();

            //                  listaDatos.Add(campo);

            //  } while (campo != "0");
            //  Console.WriteLine(" Los datos ingresados son");
            //  foreach (var item in listaDatos)
            //  {
            //      Console.WriteLine(item);


            //  }
            //Lista con Clase 
            //Persona objP = new Persona();     //utiliza constructor sin sobrecarga
            //objP.Nombre = "Karina";
            //objP.Edad = 20;

            //Persona objP2 = new Persona("Manuel",10); // utiliza constructor sobrecargado




            //List<Persona> listaPersona = new List<Persona>();
            //listaPersona.Add(new Persona ("Luis",18));  //utiliza constructor sobrecargado

            //listaPersona.Add(new Persona { Nombre ="Mariela", Edad = 18 }); //utilzia el constructor vacio
            //listaPersona.Add(objP);
            //listaPersona.Add(objP2);

            ////Listar los datos del Objeto

            //Console.WriteLine("Lista con FOR");
            //for (int i = 0; i < listaPersona.Count; i++)
            //{
            //    Console.WriteLine(listaPersona[i].Nombre +" "+listaPersona[i].Edad);
            //}
            //Console.WriteLine("Lista con FOREACH");

            //foreach (var item in listaPersona)
            //{
            //    Console.WriteLine(item.Nombre+" "+item.Edad);

            //}

            #endregion

            #region Diccionarios (Colecion de datos)

            //Dictionary<string, string> datos = new Dictionary<string, string>();
            //datos.Add("A", "Lunes");
            //datos.Add("B", "Martes");
            //datos.Add("C", "Miercoles");
            //datos.Add("D", "Jueves");
            //datos.Add("E", "Viernes");
            //datos.Add("F", "Sabado");
            //datos.Add("G", "Domingo");

            //Console.WriteLine(datos["A"]);
            //Console.WriteLine(datos["B"]);
            //Console.WriteLine(datos["C"]);

            /*
             Elaborar un algoritmo 
             
             */

            //int campo;
            // Dictionary<int  , string> datos = new Dictionary<int, string>();
            // datos.Add(1, "Lunes");
            // datos.Add(2, "Martes");
            // datos.Add(3, "Miercoles");
            // datos.Add(4, "Jueves");
            // datos.Add(5, "Viernes");
            // datos.Add(6, "Sabado");
            // datos.Add(7, "Domingo");


            // Console.WriteLine("Ingrese un numero: ");

            // campo= int.Parse(Console.ReadLine());

            // Console.WriteLine(datos[campo]);
         
            int horasExtra;
            int htra=8;
            int pago;
           



            Dictionary<int, int> datos = new Dictionary<int, int>();
            datos.Add(1, 12);
            datos.Add(2, 12);
            datos.Add(3, 12);
            datos.Add(4, 13);
            datos.Add(5, 13);
            datos.Add(6, 15);

            Console.WriteLine("INGRESE HORAS TRABAJADAS");
                
            int horas = int.Parse(Console.ReadLine());
            horasExtra = horas- 8;

            if (horasExtra<=0)
            {
                Console.WriteLine("Horas trabajadas"+ htra);
                Console.WriteLine("Costo de Horas trabajadas" + horas*10 + "S/.");
                Console.WriteLine("Horas extras: 0");
                Console.WriteLine("Costo Horas trabajadas: 0 s/.");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("el pago a realizar es de " + (horas*10)+"s/.");

            }
            else
            {
                Console.WriteLine("Horas trabajadas" + 8);
                int costoHorasT = 8 * 10;
                Console.WriteLine("Horas trabajadas" + costoHorasT +"s/.");
                int costo = datos[horasExtra];
                Console.WriteLine("Horas extras:"+horasExtra);
                int costoHorasE = horasExtra * costo;
                Console.WriteLine("costo horas extras:"+costoHorasE +"s/.");
                Console.WriteLine("----------------------------");
                Console.WriteLine("pago a realizar es de"+(costoHorasT+costoHorasE+"s/."));
                
            }

            List<Usuarios> listaPersona = new List<Usuarios>();
           listaPersona.Add(new Usuarios (1,"Luis",horas,);  
            
            for (int i = 0; i < listaPersona.Count; i++)
          {
                    Console.WriteLine(listaPersona[i].Codigo+" "+ listaPersona[i].Nombre,listaPersona[i].HorasTrabajo,listaPersona[i].PagoTotal);



                #endregion



        }

    }

    
}
