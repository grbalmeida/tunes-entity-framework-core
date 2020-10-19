using System;
using System.Linq;
using Tunes.Business.Models;
using Tunes.Data.Context;

namespace Tunes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AdicionarAlbum();
        }

        private static void AdicionarAlbum()
        {
            using (var contexto = new TunesContext())
            {
                var album = new Album
                {
                    Titulo = "Fearless",
                    Artista = contexto.Artistas.First()
                };

                contexto.Albuns.Add(album);

                contexto.SaveChanges();
            }

            Console.ReadKey();
        }

        private static void AdicionarArtista()
        {
            using (var contexto = new TunesContext())
            {
                var artista = new Artista
                {
                    Nome = "Taylor Swift"
                };

                contexto.Artistas.Add(artista);
                contexto.SaveChanges();
            }

            Console.ReadKey();
        }
    }
}
