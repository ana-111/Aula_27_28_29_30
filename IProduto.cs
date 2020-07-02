namespace Aula_27_28_29_30
{
    public interface IProduto
    {
        void Ler();
        void Adicionar(Produto _produto);
        void Remover(Produto _produto);
        void Alterar(int _cod,Produto _produtoAlterado);
    }
}