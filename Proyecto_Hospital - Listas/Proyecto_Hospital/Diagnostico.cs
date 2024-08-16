/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 27/6/2024
 * Hora: 17:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace Proyecto_Hospital
{
	/// <summary>
	/// Description of Diagnostico.
	/// </summary>
	public class Diagnostico
	{
		private int codigo;
		private string fecha;
		private List<Receta_Medica> RM;
		public Diagnostico()
		{
			codigo=777;
			fecha="9/10/20";
			RM=new List<Receta_Medica>();
			int cant_rm=2;
			for(int i=0;i<cant_rm;i++)
				RM.Add(new Receta_Medica());
		}
		public void mostrar(){
			Console.WriteLine("\n--- Mostrando datos de Diagnostico ---");
			Console.WriteLine("Codigo= "+codigo);
			Console.WriteLine("Fecha= "+fecha);
			Console.WriteLine("\nCantidad de recetas medicas= "+RM.Count);
			foreach(Receta_Medica recmed in RM)
				recmed.mostrar();
		}
		public List<Receta_Medica> LISTRECEMED{
			get{return RM;}
			set{RM=value;}
		}
		public int Codigo{
			get{return codigo;}
			set{codigo= value;}
		}
		public string Fecha{
			get{return fecha;}
			set{fecha=value;}
		}
	}
}
