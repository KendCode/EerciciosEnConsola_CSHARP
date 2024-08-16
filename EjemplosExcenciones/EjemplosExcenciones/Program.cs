/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 30/07/2024
 * Hora: 20:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace EjemplosExcenciones
{
	class Program
	{
		public static void Main(string[] args)
		{
			Excepciones E = new Excepciones();
			//E.DivideCero();
			
			E.TipoEntero();			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}