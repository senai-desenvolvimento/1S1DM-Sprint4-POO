namespace Aula26Interfaces
{
    public interface ICarrinho
    {
        // CRUD
        // Create
        // Read
        // Update
        // Delete
        void Ler();
        void Incluir(Produto _produto);
        void Excluir(Produto _produto);
        void Alterar(int _cod, Produto _produtoAlterado); 
    }
}