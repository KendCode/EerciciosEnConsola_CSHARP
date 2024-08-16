/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 27/6/2024
 * Hora: 19:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace Proyecto_Hospital
{
	/// <summary>
	/// Description of Hospital.
	/// </summary>
	public class Hospital
	{
		private string nombre;
		private string direccion;
		private int telefono;
		private List<Doctor> Doc;
		private List<Paciente> Pa;
		public Hospital(Doctor d,Paciente p)
		{
			nombre="San Juan XX";
			direccion="Villa integracion";
			telefono=2343434;
			int cant_doc=2;
			int cant_pa=2;
			Doc=new List<Doctor>();
			Pa=new List<Paciente>();
			for(int i=0;i<cant_doc;i++)
				Doc.Add(d);
			for(int i=0;i<cant_pa;i++)
				Pa.Add(p);
		}
		public void Mostrar(){
			Console.WriteLine("\n--- Mostrando datos de Hospital ---");
			Console.WriteLine("Nombre= "+nombre);
			Console.WriteLine("Direccion= "+direccion);
			Console.WriteLine("Telefono= "+telefono);
			Console.WriteLine("\nCantidad de Doctores= "+Doc.Count);
			foreach(Doctor d in Doc)
				d.mostrar();
			Console.WriteLine("\nCantidad de Pacientes= "+Pa.Count);
			foreach(Paciente p in Pa)
				p.mostrar();
		}
		public List<Paciente> LISTPA{
			get{return Pa;}
			set{Pa=value;}
		}
		public List<Doctor> LISTDOC{
			get{return Doc;}
			set{Doc=value;}
		}
	}
}
