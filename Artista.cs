/*
 * Created by SharpDevelop.
 * User: Sure7777
 * Date: 12/5/2022
 * Time: 21:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Cancion_2
{
	
	public class Artista
	{
		private string nombre;
		private int edad;
		public Artista()
		{
			nombre="Ultimo";
			edad=26;
		}
		public Artista(string n, int e)
		{
			nombre=n;
			edad=e;
		}
		public void mostrar()
		{
			Console.WriteLine("-----------ARTISTA--------------");
			Console.WriteLine("Nombre del artista: "+nombre);
			Console.WriteLine("Edad: "+edad);
			Console.WriteLine("--------------------------------");
		}
		public string NombreArtista{
			get {return nombre;}
		}
	}
}
