using System.Collections.Generic;

namespace Aula26Interfaces
{
    public class Carrinho : ICarrinho
    {
        List<Produto> carrinho = new List<Produto>();

        public void Alterar(int _cod, Produto _produtoAlterado)
        {
            carrinho.Find(j => j.Codigo == _cod).Nome = _produtoAlterado.Nome;
            carrinho.Find(k => k.Codigo == _cod).Preco = _produtoAlterado.Preco;
        }

        public void Excluir(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void Incluir(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Ler()
        {
            foreach(Produto item in carrinho){
                System.Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }
        }


    }
}