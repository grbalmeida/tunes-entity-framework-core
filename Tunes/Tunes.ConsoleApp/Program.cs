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
            AdicionarFuncionario();
        }

        private static void AdicionarFuncionario()
        {
            using (var contexto = new TunesContext())
            {
                var funcionario = new Funcionario
                {
                    PrimeiroNome = "Maria",
                    Sobrenome = "da Silva",
                    Titulo = "Maria da Silva",
                    Cidade = "São Paulo",
                    Estado = "São Paulo",
                    DataAdmissao = new DateTime(2020, 1, 1),
                    DataNascimento = new DateTime(1988, 10, 23),
                    Email = "maria@gmail.com",
                    Endereco = "Rua das Flores",
                    CEP = "11111-111",
                    Fax = "12121212",
                    Fone = "13131313",
                    Pais = "Brasil",
                    Gerente = new Funcionario
                    {
                        PrimeiroNome = "Jorge",
                        Sobrenome = "Fonseca",
                        Titulo = "Jorge Fonseca",
                        DataAdmissao = new DateTime(2017, 5, 20),
                        DataNascimento = new DateTime(1980, 8, 15),
                        Email = "jorge@outlook.com",
                        Fone = "15153030"
                    }
                };

                contexto.Funcionarios.Add(funcionario);

                contexto.SaveChanges();
            }

            Console.ReadKey();
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
