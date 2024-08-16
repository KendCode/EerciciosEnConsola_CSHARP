/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 27/6/2024
 * Hora: 19:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

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
		private int cant_doc;
		private int cant_pa;
		private Doctor[] Doc;
		private Paciente[]Pa;
		public Hospital(Doctor d,Paciente p)
		{
			nombre="San Juan XX";
			direccion="Villa integracion";
			telefono=2343434;
			cant_doc=2;
			cant_pa=2;
			Doc=new Doctor[cant_doc];
			Pa=new Paciente[cant_pa];
			for(int i=0;i<cant_doc;i++)
				Doc[i]=d;
			for(int i=0;i<cant_pa;i++)
				Pa[i]=p;
		}
		public void Mostrar(){
			Console.WriteLine("\n--- Mostrando datos de HOSPITAL ---");
			Console.WriteLine("Nombre= "+nombre);
			Console.WriteLine("Direccion= "+direccion);
			Console.WriteLine("Telefono= "+telefono);
			Console.WriteLine("Cantidad de Doctores= "+cant_doc);
			for(int i=0;i<cant_doc;i++)
				Doc[i].mostrar();
			Console.WriteLine("Cantidad de Pacientes= "+cant_pa);
			for(int i=0;i<cant_pa;i++)
				Pa[i].mostrar();
		}
		//a) 1ra forma
		public void BuscarPaciente(){
			Console.Write("\nIngrese ci: ");
			int x = int.Parse(Console.ReadLine());
			Console.Write("\nIngrese codigo de diagnostico: ");
			int y = int.Parse(Console.ReadLine());
			for(int i=0;i<cant_pa;i++)
				if(Pa[i].Ci.Equals(x) & Pa[i].RV.DAIG.CodDia.Equals(y))
					for(int j=0;j<Pa[i].RV.DAIG.ResM.CantMed;j++)
						Console.WriteLine("\nNombre medicamento= "+Pa[i].RV.DAIG.ResM.ME[j].NombreMed);
		}
		//b) 2da forma
		public void BuscarPersona2(){
			Console.Write("\nIngrese nombre de la persona a buscar: ");
			string x = Console.ReadLine();
			for(int i=0;i<cant_pa;i++)
				Pa[i].BuscarPersona1(x);
			for(int i=0;i<cant_doc;i++)
				Doc[i].BuscarPersona1(x);
		}
		//c) 
		public void ModificaCodigo(){
			Console.Write("\nIngrese fecha de revision medica: ");
			string x = Console.ReadLine();
			for(int i=0;i<cant_pa;i++){
				if(Pa[i].RV.Fecha.Equals(x)){
					Console.Write("\nNuevo codigo de diagnostico: ");
					Pa[i].RV.DAIG.CodDia=int.Parse(Console.ReadLine());
					Console.Write("\nNuevo codigo de reseta medica: ");
					Pa[i].RV.DAIG.ResM.CodRe=int.Parse(Console.ReadLine());
					Pa[i].mostrar();
				}
			}
		}
	}
}
