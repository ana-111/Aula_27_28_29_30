using System.IO;

namespace Aula_27_28_29_30 {
    public class Produto {

     
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/produto.csv";

        public Produto () {

            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }

        public void Cadastrar (Produto p)
         {
            var Linha = new string[] { p.PrepararLinha (p) };
            File.AppendAllLines (PATH, Linha);
        }

        private string PrepararLinha (Produto produto) {
            return $"codigo= {produto.Codigo}; nome= {produto.Nome}; preco= {produto.Preco};";
        }

    }
}