using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set;}
        private string Titulo { get; set;}
        private string Sinopse { get; set;}
        private int Ano { get; set;}

        // Métodos
        public Serie(int id, Genero genero, string titulo, string sinopse, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Sinopse = sinopse;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Enviroment.NewLine;
            retorno += "Título: " + this.Titulo + Enviroment.NewLine;
            retorno += "Sinopse: " + this.Sinopse + Enviroment.NewLine;
            retorno += "Ano de Lançamento: " + this.Ano;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
    }
}