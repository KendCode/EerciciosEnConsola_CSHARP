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
			Pa=new List<Paciente>();;
			for(int i=0;i<cant_doc;i++)
				Doc.Add(d);
			for(int i=0;i<cant_pa;i++)
				Pa.Add(p);
		}
		public void Mostrar(){
			Console.WriteLine("\n--- Mostrando datos de HOSPITAL ---");
			Console.WriteLine("Nombre= "+nombre);
			Console.WriteLine("Direccion= "+direccion);
			Console.WriteLine("Telefono= "+telefono);
			Console.WriteLine("Cantidad de Doctores= "+Doc.Count);
			foreach(Doctor d in Doc)
				d.mostrar();
			Console.WriteLine("Cantidad de Pacientes= "+Pa.Count);
			foreach(Paciente p in Pa)
				p.mostrar();
		}
		public string Nombre{ 
			get{return nombre;}
			set{nombre = value;}
		}
		
		//a)1ra forma
		public void BuscarPacviente(){
			Console.Write("\n Ingrese ci del paciente a buscar: ");
			int x = int.Parse(Console.ReadLine());
			Console.Write("\n Ingrese codigo de diagnostico a buscar: ");
			int y = int.Parse(Console.ReadLine());
			foreach(Paciente p in Pa){
				if(p.Ci.Equals(x) & p.RV.DAIG.CodDia.Equals(y)){
					foreach(Medicamento me in p.RV.DAIG.ResM.LISTME){
						Console.WriteLine("\nNombre del medicamento= "+me.NombreMed);
					}
				}
			}
		}
		//a) 2da forma
		public void BuscarPaciente6(){
			Console.WriteLine("\nIngrese ci: ");
			int x = int.Parse(Console.ReadLine());
			Console.Write("\nIngrese codigo de diagnostico: ");
			int y = int.Parse(Console.ReadLine());
			foreach(Paciente p in Pa)
				p.BuscarPaciente5(x,y);
		}
		//b) 1ra forma
		public void BuscarPersona(){
			Console.Write("\nIngrese el nombre de la persona buscar: ");
			string x= Console.ReadLine();
			foreach(Doctor d in Doc){
				if(d.NombreP.ToLower().Equals(x)){
					Console.Write("\nNuevo numero de celular: ");
					d.Cel=int.Parse(Console.ReadLine());
					Console.Write("\nNueva direccion: ");
					d.Direc=Console.ReadLine();
					d.mostrar();
				}
			}
			foreach(Paciente d in Pa){
				if(d.NombreP.ToLower().Equals(x)){
					Console.Write("\nNuevo numero de celular: ");
					d.Cel=int.Parse(Console.ReadLine());
					Console.Write("\nNueva direccion: ");
					d.Direc=Console.ReadLine();
					d.mostrar();
				}
			}
		}
		//b)2da forma
		public void BuscarPersona2(){
			Console.Write("\nIngrese nombre de la persona a buscar: ");
			string x = Console.ReadLine();
			foreach(Doctor d in Doc)
				d.BuscarPersona1(x);
			foreach(Paciente p in Pa)
				p.BuscarPersona1(x);
					
		}
		//c)1ra Forma
		public void ModificarCodigo(){
			Console.Write("\nIngrese fecha de revision medica a buscar: ");
			string x = Console.ReadLine();
			foreach(Paciente p in Pa){
				if(p.RV.Fecha.Equals(x)){
					Console.Write("\nIngrese nuevo codigo de diagnostico: ");
					p.RV.DAIG.CodDia=int.Parse(Console.ReadLine());
					Console.Write("\nIngrese nuevo codigo de receta medica: ");
					p.RV.DAIG.ResM.CodRe=int.Parse(Console.ReadLine());
					p.mostrar();
				}
			}
				
		}
	}
}
