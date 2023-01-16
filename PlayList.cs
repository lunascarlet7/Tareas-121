/*
 * Created by Tania Pinto.
 */
using System;

namespace Cancion_2
{
	
	public class PlayList
	{
		private string nombrep;
		private int nroCanciones;
		private Cancion [] canciones=new Cancion[50];
		public PlayList(string np)
		{
			nombrep=np;
			//ES AGREGACION. NO HAY OTRO CONSTRUCTOR.
			nroCanciones=0;
			
		}
		public PlayList(string np, int nc)
		{
			nombrep=np;
			nroCanciones=nc;
		}
		public void adiCanciones(Cancion c1){
			nroCanciones++;
			canciones[nroCanciones] = c1; 
		}
		public void mostrar()
		{
			Console.WriteLine("------♫ ♫ MOSTRANDO PLAYLIST ♫ ♫--------");
			Console.WriteLine("Nombre PlayList: "+nombrep+"Nro. Canciones: "+nroCanciones);
			for(int i=1;i<=nroCanciones;i++){
				canciones[i].mostrar();
			}
		}
		public int NroCanciones{
			get {return nroCanciones;}
		}
		
	}
}
