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
            AdicionarFaixa();
        }

        private static void AdicionarFaixa()
        {
            using (var contexto = new TunesContext())
            {
                var faixa = new Faixa
                {
                    Nome = "Bad Blood",
                    Album = contexto.Albuns.First(),
                    Genero = contexto.Generos.First(),
                    TipoMidia = contexto.TiposDeMidia.First(),
                    PrecoUnitario = 10,
                    Bytes = 50000,
                    Milissegundos = 1000 * 60 * 3,
                    Compositor = "Taylor Swift"
                };

                contexto.Faixas.Add(faixa);

                contexto.SaveChanges();
            }

            Console.ReadKey();
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
