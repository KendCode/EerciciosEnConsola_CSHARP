/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 27/6/2024
 * Hora: 17:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto_Hospital
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		protected int ci;
		protected string nombre;
		protected int cel;
		protected string direccion;
		public Persona()
		{
			ci=12345;
			nombre="Juan Ramos Diaz";
			cel=7777777;
			direccion="avenida bolvia nro 100";
		}
		public void mostrar(){
			Console.WriteLine("CI= "+ci);
			Console.WriteLine("Nombre= "+nombre);
			Console.WriteLine("Celular= "+cel);
			Console.WriteLine("Dirección= "+direccion);
		}
		public int Ci{
			get{return ci;}
			set{ci= value;}
		}
		public string NombreP{
			get{return nombre;}
			set{nombre= value;}
		}
		public int Cel{
			get{return cel;}
			set{cel=value;}
		}
		public string Direc{
			get{return direccion;}
			set{direccion= value;}	
		}
		//b)2daforam
		public void BuscarPersona1(string x){
			if(nombre.ToLower().Equals(x.ToLower())){
				Console.Write("\nNuevo nro de celuylar persona: ");
				cel=int.Parse(Console.ReadLine());
				Console.Write("\nNueva direccion persona: ");
				direccion=Console.ReadLine();
				mostrar();
			}
		}
	}
}
