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
			//a) BUSCAR PACIENTE CI "X" Y CODIGO "Y" DE DIAGNOSTICO 
			//MOSTRAR NOMBRE DE TODOS LOS MEDICAMENTOS 1RA FORMA
			//H.BuscarPacviente();
			//a) 2da forma
			//H.BuscarPaciente6();
			
			//B) ENTRE LAS PERSONAS DEL HOSAPITAL BUSCAR AL QUE CORRESPA EL NOMBRE "X" 
			//MODIFICAR SU CELULAR Y DIRECCION
			//B)PRIMERA FORMA
			//H.BuscarPersona();
			//B)SEGUNDA FORMA			
			//H.BuscarPersona2();
			
			//c)1ra forma
			H.ModificarCodigo();
			//c)2da forma
			
			
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}