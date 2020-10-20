using System;

namespace Tunes.Business.Models
{
    public class Faixa
    {
        public int FaixaId { get; set; }
        public string Nome { get; set; }
        public string Compositor { get; set; }
        public int Milissegundos { get; set; }
        public int Bytes { get; set; }
        public decimal PrecoUnitario { get; set; }

        public Album Album { get; set; }
        public TipoMidia TipoMidia { get; set; }
        public Genero Genero { get; set; }
    }
}
