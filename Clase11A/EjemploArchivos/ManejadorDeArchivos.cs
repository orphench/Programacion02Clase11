using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace EjemploArchivos
{
   public class ManejadorDeArchivos
    {

        public static void Leer()
        {
            try
            {
                string datos;
                StreamReader lector = new StreamReader("Archivo/ejemplo.txt");//crear la carpeta en bin/debug->Archivo
                datos = lector.ReadToEnd();
                lector.Close();
                Console.WriteLine(datos);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public static void escribir()
        {
            try
            {
                //bool resp = true;
                StreamWriter escritor = new StreamWriter("Archivo/ejemplo.txt");//crear la carpeta en bin/debug->Archivo

                escritor.WriteLine("Hola mundo");
                escritor.Write("c#\n");
                escritor.WriteLine("Escritura en archivos");

                escritor.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void escribirDos()//para toda escritura en archivo tiene q estar el Try Catch
        {
            try
            {

                using (StreamWriter escritor = new StreamWriter("Archivos/ejemplo.txt"))
                {
                    escritor.WriteLine("Hola mundo");
                    escritor.Write("c#\n");
                    escritor.WriteLine("Escritura en archivos");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }  
    }
}
