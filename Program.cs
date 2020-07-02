using System;
using System.Collections.Generic;

namespace Aula_27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.Codigo = 5;
            p.Nome = "Celular";
            p.Preco = 1.500f;

            p.Cadastrar(p);
            p.Remover("Celular");

            Produto alterado = new Produto();
            alterado.Codigo  = 5;
            alterado.Nome    = "TV";
            alterado.Preco   = 10.000f;

            p.Alterar(alterado);

            List<Produto> lista = p.Filtrar("Casa");
            lista = p.Ler();

            foreach (Produto item in lista){
                Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }
        }
    }
}
