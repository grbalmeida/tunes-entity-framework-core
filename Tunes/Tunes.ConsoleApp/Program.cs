using System;
using System.Collections.Generic;
using System.Linq;
using Tunes.Business.Models;
using Tunes.Data.Context;

namespace Tunes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AdicionarNotaFiscal();
        }

        private static void AdicionarNotaFiscal()
        {
            using (var contexto = new TunesContext())
            {
                var notaFiscal = new NotaFiscal
                {
                    CEP = "14000-000",
                    Endereco = "Rua dos Arcos",
                    Cidade = "Rio de Janeiro",
                    Estado = "Rio de Janeiro",
                    Pais = "Brasil",
                    Total = 1000,
                    DataNotaFiscal = new DateTime(2020, 1, 30),
                    Cliente = contexto.Clientes.First()
                };

                contexto.NotasFiscais.Add(notaFiscal);

                contexto.SaveChanges();
            }

            Console.ReadKey();
        }

        private static void AdicionarCliente()
        {
            using (var contexto = new TunesContext())
            {
                var cliente = new Cliente
                {
                    PrimeiroNome = "Rodolfo",
                    Sobrenome = "Pires",
                    Email = "rodolfo@yahoo.com.br",
                    Cidade = "Belo Horizonte",
                    Estado = "Minas Gerais",
                    CEP = "19191-000",
                    Empresa = "Mercearia do Pires",
                    Endereco = "Rua das Magnólias",
                    Fax = "14411441",
                    Fone = "17711771",
                    Pais = "Brasil",
                    Suporte = contexto.Funcionarios.First()
                };

                contexto.Clientes.Add(cliente);

                contexto.SaveChanges();
            }

            Console.ReadKey();
        }

        private static void AdicionarRelacionamentoEntrePlaylistEFaixas()
        {
            using (var contexto = new TunesContext())
            {
                var faixa = new Faixa
                {
                    Nome = "Despacito",
                    Compositor = "Luis Fonsi",
                    Album = new Album
                    {
                        Titulo = "Despacito",
                        Artista = new Artista
                        {
                            Nome = "Luis Fonsi"
                        }
                    },
                    Bytes = 50000,
                    Milissegundos = 1000 * 60 * 4,
                    Genero = new Genero
                    {
                        Nome = "Latino"
                    },
                    PrecoUnitario = 5,
                    TipoMidia = new TipoMidia
                    {
                        Nome = "MP4"
                    }
                };

                var playlist = new Playlist
                {
                    Nome = "Mais tocada",
                    Faixas = new List<PlaylistFaixa>
                    {
                        new PlaylistFaixa
                        {
                            Faixa = faixa
                        }
                    }
                };

                contexto.Playlists.Add(playlist);

                contexto.SaveChanges();
            }

            Console.ReadKey();
        }

        private static void AdicionarPlaylist()
        {
            using (var contexto = new TunesContext())
            {
                var playlist = new Playlist
                {
                    Nome = "50 músicas mais tocadas do verão"
                };

                contexto.Playlists.Add(playlist);

                contexto.SaveChanges();
            }

            Console.ReadKey();
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
