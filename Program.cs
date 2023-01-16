/*
 * Created by Tania Pinto.
   Follow me !! ^^
 */
using System;

namespace Cancion_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Cancion c=new Cancion();
			Cancion c2=new Cancion("Be the Light",6,"RockPop");
			//NO MANDAR ARGUMENTOS A PLAYLIST
			//PORQUE ES AGREGACION
			//-----------------------------------------------------
			PlayList pl1= new PlayList("miau miauuu grr");
			pl1.adiCanciones(c);
			pl1.adiCanciones(c2);
			pl1.adiCanciones(c);
			pl1.adiCanciones(c);
			pl1.mostrar();
			//-----------------------------------------------------
			PlayList pl2= new PlayList("my songs cuuute");
			pl2.adiCanciones(c);
			pl2.adiCanciones(c);
			pl2.mostrar();
			MyPlayLists m= new MyPlayLists();
			m.adiPlaylist(pl1);
			m.adiPlaylist(pl2);
			//b)
			Console.WriteLine("----------------♫ ♫ VECTOR DE PLAYLISTS ♫ ♫------------------");
			m.mostrarp(pl2);
			m.verifica("Ricardo arjona");
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
