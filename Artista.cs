/*
 * Created by Tania Pinto.*/
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
