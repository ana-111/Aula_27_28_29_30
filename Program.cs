using System;
using System.Collections.Generic;

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

            // p.Cadastrar(p);
            p.Remover("Celular");

            List<Produto> lista = p.Filtrar("Casa");
            lista = p.Ler();

            foreach (Produto item in lista){
                Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }
        }
    }
}
