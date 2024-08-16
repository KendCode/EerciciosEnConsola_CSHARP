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
	class Program
	{
		public static void Main(string[] args)
		{
			Hospital H =new Hospital(new Doctor(),new Paciente());
			H.Mostrar();
			//a) 
			//H.BuscarPaciente();
			//b)
			//H.BuscarPersona2();
			//c) 
			H.ModificaCodigo();
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}