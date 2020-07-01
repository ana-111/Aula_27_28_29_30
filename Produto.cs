using System;
using System.Collections.Generic;
using System.IO;

namespace Aula_27_28_29_30 
{
    public class Produto 
    {

     
        public Produto(int codigo, string nome, float preco) 
        {
            this.Codigo = codigo;
                this.Nome = nome;
                this.Preco = preco;
               
        }
                public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/produto.csv";

        public Produto () {

            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }

        public List<Produto> Ler()
        {
            
            List<Produto> prod = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string linha in linhas)
            {

                string[] dado = linha.Split(";");

                Produto p = new Produto();

                p.Codigo = Int32.Parse(Separar(dado[0]));
                p.Nome = Separar(dado[1]);
                p.Preco = float.Parse(Separar(dado[2]));

                prod.Add(p);

            }
            
            return prod;
        }

        public string Separar(string dado){
            return dado.Split("=")[1];
        }

        public void Cadastrar (Produto p)
         {
            var Linha = new string[] { p.PrepararLinha (p) };
            File.AppendAllLines (PATH, Linha);
        }

        private string PrepararLinha (Produto produto) {
            return $"codigo= {produto.Codigo}; nome= {produto.Nome}; preco= {produto.Preco};";
        }

        public List<Produto> Filtrar(string _nome)
        {
            return Ler().FindAll(x => x.Nome == _nome);
        }

        public void Remover(string _termo)
        {
            List<string> lines = new List<string>();

            using (StreamReader file = new StreamReader(PATH))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    lines.Add(line);
                }
                lines.RemoveAll(l => l.Contains(_termo));
            }

            using (StreamWriter output = new StreamWriter(PATH))
            {
                output.Write(string.Join(Environment.NewLine, lines.ToArray()));
            } 
        }

    }
}