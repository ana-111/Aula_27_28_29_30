using System;

namespace Aula_27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.Codigo = 1;
            p.Nome = "Celular";
            p.Preco = 1.500f;

            p.Cadastrar(p);
        }
    }
}
