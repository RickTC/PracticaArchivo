using System;
using System.IO;
using System.Collections;

namespace Practica4
{
	public class Funciones
	{
		RegistraPersona registrar = new  RegistraPersona();
		ArrayList arraywords = new ArrayList();
		
		public Funciones ()
		{
			this.registrar = new RegistraPersona();
			this.arraywords = new ArrayList();			
		}
		
		public void leerArchivo()
		{
			string uarchivo;
			
				try
				{
					Console.WriteLine ("Ingrese nombre de archivo o ubicacion");
					uarchivo = Console.ReadLine();
				
					StreamReader leer = new StreamReader (uarchivo);
					string linea = leer.ReadLine();
					
					while(linea != null)
					{	
						char [] delimita={'.','-',','};
						string [] pal = linea.Split(delimita);
					
						RegistraPersona reg = new RegistraPersona();
					
						reg.id = pal[0];
						reg.nombre = pal[1];
						reg.domicilio = pal[2];
						reg.telefono = pal[3];
						
						arraywords.Add(reg);
						linea = leer.ReadLine();
							
					}
						leer.Close();
				}
			    catch(Exception e)
				{
					Console.WriteLine ("Exception"+e.Message);				
				}
				finally
				{
					Console.WriteLine ("Termino lectura");	
				}
			
		}
		
		public void imprimir()
		{
				foreach(object Captura in arraywords)
				{
					this.registrar = (RegistraPersona)Captura;
					verlista();
				}
		}
		public void verlista()
		{
			Console.WriteLine ("Id: " + registrar.id);
			Console.WriteLine ("Nombre: "+ registrar.nombre);
			Console.WriteLine ("Domicilio: "+ registrar.domicilio);
			Console.WriteLine ("Telefono: "+ registrar.telefono);
			Console.WriteLine ();
		}	
		
	}
}

