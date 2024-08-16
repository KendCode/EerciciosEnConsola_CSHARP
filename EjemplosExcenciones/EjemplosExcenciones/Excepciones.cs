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
	/// <summary>
	/// Description of Excepciones.
	/// </summary>
	public class Excepciones
	{
		public Excepciones()
		{
		}
		//CONTROLAR LA DIVISION ENTRE CERO
		public void DivideCero(){
			int n1, n2, r=0;
			Console.Write("\nIngrese n1: ");
			n1= int.Parse(Console.ReadLine());
			bool bandera;
			do{
				bandera = false;
				try{
					Console.Write("\nIngrese n2: ");
					n2=int.Parse(Console.ReadLine());
					r = n1/n2; 	
				}
				catch(DivideByZeroException e){
					Console.WriteLine(e.Message);
				}
				finally{
					Console.WriteLine("\nResultado: "+r);
				}
				
			}while(bandera);
		}
		//CONTROLAR DATOS DE TIPO: INT LONG BYTE Y SHORT
		public void TipoEntero(){
			int n=0;
			bool bandera;
			do{
				bandera = false;
				try{
				Console.Write("\nIngrese Numero: ");
				n=short.Parse(Console.ReadLine());
				
				}
				catch(OverflowException e){
					Console.WriteLine("Error.. "+e.Message);
					bandera = true;
				}
				catch(FormatException e){
					Console.WriteLine("Error.. "+e.Message);
					bandera = true;
				}
			}while(bandera);
			Console.WriteLine("\nNumero= "+n);
			
		}
	}
}
