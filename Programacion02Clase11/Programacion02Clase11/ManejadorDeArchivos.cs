using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Programacion02Clase11
{
    class ManejadorDeArchivos
    {

        public static void EscribirDos()
        {
            try
            {
               using (StreamWriter escritor = new StreamWriter("Archivo/ejemplo.txt", true))
               {
                    escritor.WriteLine("Hola mundo");
                    escritor.Write("C#");
                    escritor.WriteLine("\nEscritura en archivo");
               }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Leer()
        {
            try
            {
                StreamReader lector = new StreamReader("Archivo/ejemplo.txt");
                string datos;
                datos = lector.ReadToEnd();
                lector.Close();
                Console.WriteLine(datos);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public static void Escribir()
        {
            try
            {
                StreamWriter escritor = new StreamWriter("Archivo/ejemplo.txt", false);
                escritor.WriteLine("Hola mundo");
                escritor.Write("C#");
                escritor.WriteLine("\nEscritura en archivo");
                escritor.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
