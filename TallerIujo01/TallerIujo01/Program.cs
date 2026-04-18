/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 17/4/2026
<<<<<<< HEAD
 * Hora: 10:53 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
=======
 * Hora: 10:53 a. m.
 * * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
>>>>>>> 6400248 (Subiendo cambios del proyecto)
 */
using System;
using System.IO;

namespace TallerIujo01
<<<<<<< HEAD
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine(" ===taller 01=== ");
			
			// 1 El dato del usuario
			string registroUsuario = "      ID_777; juanperez;  EVALUACION; 95";
			
			Console.WriteLine(registroUsuario);
			string registroLimpio = registroUsuario.Trim();
			Console.WriteLine(registroLimpio);
			
			string[] partes = registroLimpio.Split(';');
			string id = partes[0].Trim();
			string nombre = partes[1].Trim();
			string tarea = partes[2].Trim();
			string nota = partes[3].Trim();
			
			Console.WriteLine(string.Format("el id es: {0} del usuario {1} con la nota {2}",id,nombre, nota));

			

			
			// flujo en archivos
			string rutaraiz = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"DatosIUJO");
			
			if(!Directory.Exists(rutaraiz)){
				Directory.CreateDirectory(rutaraiz);
				Console.WriteLine("creado directorio correctamente");
			}
			
			string archivotexto =Path.Combine(rutaraiz,"reportes","notas.txt");
			Console.WriteLine (archivotexto);
			
			using( StreamWriter sw = new StreamWriter (archivotexto,true)){
				
				sw.WriteLine(string.Format(" ID : {0} : nota {1} {yyyy-MM-dd HH:mm }", id, nota, DateTime.Now));
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
=======

{

    class Program

    {

        public static void Main(string[] args)

        {

            

            Console.WriteLine(" ===taller 01=== ");

            

            // 1 El dato del usuario

            string registroUsuario = "      ID_777; juanperez;  EVALUACION; 95";

            

            Console.WriteLine(registroUsuario);

            string registroLimpio = registroUsuario.Trim();

            Console.WriteLine(registroLimpio);

            

            string[] partes = registroLimpio.Split(';');

            string id = partes[0].Trim();

            string nombre = partes[1].Trim();

            string tarea = partes[2].Trim();

            string nota = partes[3].Trim();

            

            Console.WriteLine(string.Format("el id es: {0} del usuario {1} con la nota {2}",id,nombre, nota));


            


            

            // flujo en archivos

            string rutaraiz = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"DatosIUJO");

            

            if(!Directory.Exists(rutaraiz)){

                Directory.CreateDirectory(rutaraiz);

                Console.WriteLine("creado directorio correctamente");

            }

            string rutareportes = Path.Combine(rutaraiz, "reportes");

            if(!Directory.Exists(rutareportes)){

                Directory.CreateDirectory(rutareportes);

            }

            string archivotexto =Path.Combine(rutareportes,"notas.txt");

            Console.WriteLine (archivotexto);

            

            using( StreamWriter sw = new StreamWriter (archivotexto,true)){

                

                sw.WriteLine(string.Format(" ID : {0} : nota {1} {2:yyyy-MM-dd HH:mm }", id, nota, DateTime.Now));

            }

            Console.WriteLine("\n--- Desafío 1: Validador ---");
            Console.WriteLine("Ingrese usuario y clave (formato: usuario;clave):");
            string inputUsuario = Console.ReadLine(); 
            
            if (!string.IsNullOrEmpty(inputUsuario) && inputUsuario.Contains(";"))
            {
                string[] partesSeguridad = inputUsuario.Split(';');
                if (partesSeguridad.Length >= 2 && partesSeguridad[1].Contains("123"))
                {
                    string rutaSeguridad = Path.Combine(rutaraiz, "seguridad.txt");
                    using (StreamWriter swSeguridad = new StreamWriter(rutaSeguridad, true))
                    {
                        swSeguridad.WriteLine("Clave Débil detectada");
                    }
                    Console.WriteLine("Clave débil detectada. Aviso guardado en seguridad.txt");
                }
                else
                {
                    Console.WriteLine("La clave es segura o no contiene '123'.");
                }
            }
            else
            {
                Console.WriteLine("Formato incorrecto. Debes usar el formato usuario;clave");
                Console.WriteLine("El programa se va a cerrar.");
                Console.ReadKey(true);
                return;
            }

            Console.WriteLine("\n--- Desafío 2: Clonador ---");
            string rutaAvatar = Path.Combine(rutaraiz, "avatar.jpg");
            string rutaRespaldo = Path.Combine(rutaraiz, "respaldo.jpg");

            if (File.Exists(rutaAvatar))
            {
                using (FileStream fsOrigen = new FileStream(rutaAvatar, FileMode.Open, FileAccess.Read))
                using (FileStream fsDestino = new FileStream(rutaRespaldo, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024];
                    int bytesLeidos;
                    while ((bytesLeidos = fsOrigen.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fsDestino.Write(buffer, 0, bytesLeidos);
                    }
                }
                Console.WriteLine("Se ha creado un respaldo de la imagen en: " + rutaRespaldo);
            }
            else
            {
                Console.WriteLine("No se encontro avatar.jpg para copiar.");
            }

            Console.WriteLine("\n--- Desafío 3: Buscador ---");
            string[] archivosEnCarpeta = Directory.GetFiles(rutaraiz);
            foreach (string archivo in archivosEnCarpeta)
            {
                FileInfo infoArchivo = new FileInfo(archivo);
                if (infoArchivo.Length > 5120) 
                {
                    File.Delete(archivo);
                    Console.WriteLine("Se eliminó el archivo por superar los 5KB: " + infoArchivo.Name);
                }
            }
            
            Console.Write("\nPress any key to continue . . . ");
            Console.ReadKey(true);

        }

    }

>>>>>>> 6400248 (Subiendo cambios del proyecto)
}