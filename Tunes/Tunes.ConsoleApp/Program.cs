using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Tunes.Business.Models;
using Tunes.Data.Context;

namespace Tunes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AdicionarTipoMidia();
        }

        private static void AdicionarTipoMidia()
        {
            using (var contexto = new TunesContext())
            {
                var tipoMidia = new TipoMidia
                {
                    Nome = "MP3"
                };

                contexto.TiposDeMidia.Add(tipoMidia);

                contexto.SaveChanges();
            }

            Console.ReadKey();
        }

        private static void AdicionarGenero()
        {
            using (var contexto = new TunesContext())
            {
                var genero = new Genero
                {
                    Nome = "Country Pop"
                };

                contexto.Generos.Add(genero);

                contexto.SaveChanges();
            }

            Console.ReadKey();
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
