/*
 * Created by SharpDevelop.
 * User: Sure7777
 * Date: 12/5/2022
 * Time: 21:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Cancion_2
{
	
	public class Cancion
	{
		private string nombre;
		private int duracion;
		private string genero;
		//primero asi
		private Artista artista;
		
		public Cancion()
		{
			nombre="Solo";
			duracion=5;
			genero="hip hop";
			artista= new Artista();
		}
		public Cancion(string nom,int dur,string gen)
		{
			nombre=nom;
			duracion=dur;
			genero=gen;
			//composicion
			artista=new Artista("Takahiro M.",28);
			
			
		}
		public void mostrar()
		{
			Console.WriteLine("---------------------------------------------------");
			Console.WriteLine("Nombre de la canción: "+nombre);
			Console.WriteLine("Duración: "+duracion);
			Console.WriteLine("Género: "+genero);
			//muestras ya con todo
			artista.mostrar();
		
		}
		public Cancion Nom{
			get {return Cancion;}
		}
	}
}
