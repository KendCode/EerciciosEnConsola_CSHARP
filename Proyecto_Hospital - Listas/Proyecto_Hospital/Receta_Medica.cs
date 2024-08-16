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
	/// Description of Receta_Medica.
	/// </summary>
	public class Receta_Medica
	{
		private int codigo;
		private string fecha;
		private List<Medicamento> M;
		public Receta_Medica()
		{
			codigo=333;
			fecha="3/5/23";
			int cant_med=2;
			M=new List<Medicamento>();
			for(int i=0;i<cant_med;i++)
				M.Add(new Medicamento());
		}
		public void mostrar(){
			Console.WriteLine("\n--- Mostrando datos de Receta Medica ---");
			Console.WriteLine("Codigo= "+codigo);
			Console.WriteLine("Fecha= "+fecha);
			Console.WriteLine("\nCantidad de medicamentos= "+M.Count);
			foreach(Medicamento me in M)
				me.mostrar();
		}
		public List<Medicamento> LISTMED{
			get{return M;}
			set{M=value;}
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
