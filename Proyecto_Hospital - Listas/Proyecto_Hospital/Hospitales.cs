/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 25/7/2024
 * Hora: 10:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace Proyecto_Hospital
{
	/// <summary>
	/// Description of Hospitales.
	/// </summary>
	public class Hospitales
	{
		private List<Hospital> Ho;
		public Hospitales(){
			int cant_hos=2;
			Ho=new List<Hospital>();
			for(int i=0;i<cant_hos;i++)
				Ho.Add(new Hospital(new Doctor(), new Paciente()));
		}
		public void Mostrar(){
			Console.WriteLine("\n--- Mostrando datos de los HOSPITALES ---");
			Console.WriteLine("\nCantidad de Hospitales= "+Ho.Count);
			foreach(Hospital h in Ho)
				h.Mostrar();
		}
	}
}
