/*
 * Created by Tania Pinto.
 */
using System;

namespace Cancion_2
{
	
	public class MyPlayLists
	{
		private int nroPlayList;
		private PlayList [] vplaylists= new PlayList[50];
		public MyPlayLists()
		{
			nroPlayList=0;
		}
		//falta con argumentos
		public void adiPlaylist(PlayList p1){
			nroPlayList++;
			vplaylists[nroPlayList] = p1;
		}
		public void mostrarp(PlayList x)
		{
			
			Console.WriteLine("Nro.Playlists son ♫: "+nroPlayList+" ♫ ");
			for(int i=1;i<=nroPlayList;i++){
				if((vplaylists[i].NroCanciones)>(x.NroCanciones)){
					vplaylists[i].mostrar();
				}
			}
		}
		
		
	}
}
