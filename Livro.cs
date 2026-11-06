using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício
{
    public class Livro
    {
        public string? Titulo { get; set; }

        public string? Autor { get; set; }

        public int NumPaginas { get; set; }

        public Livro()
        {
            Titulo = "Sem titulo";
            Autor = "Sem autor";
            NumPaginas = 0;
        }

        public Livro(string titulo)
        {
            Titulo = titulo;
        }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public Livro(string titulo, string autor, int nPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumPaginas = nPaginas;
        }
    }
}