/*
 * Created by SharpDevelop.
 * User: Sure7777
 * Date: 12/5/2022
 * Time: 21:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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
