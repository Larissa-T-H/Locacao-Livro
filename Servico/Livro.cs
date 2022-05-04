using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Aula63_Exer2_Locacao.Servico
{
    public class Livro
    {
        public int IDLivro { get; set; }
        public string NomeDoLivro { get; set; }
        public Livro(int IdLivro, string nomeDoLivro)
        {
            this.NomeDoLivro = nomeDoLivro;
            this.IDLivro = IdLivro;
        }

        public override string ToString()
        {
            return IDLivro.ToString() + " - " + NomeDoLivro;
        }

        public class RepositoryLivros
        {
            public static List<Livro> InicializarLivros()
            {
                List<Livro> livros = new List<Livro>();
                livros.Add(new Livro(254, "Como eu era antes de você"));
                livros.Add(new Livro(985, "A Cabana"));
                livros.Add(new Livro(021, "Simplemente Acontece"));
                livros.Add(new Livro(654, "A culpa é das estrelas"));
                return livros;
            }
        }
    }
}
