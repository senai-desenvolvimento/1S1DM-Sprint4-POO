namespace Aula26Interfaces
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        public Produto(){

        }

        public Produto(int _cod, string _nome, float _preco){
            this.Codigo = _cod;
            this.Nome = _nome;
            this.Preco = _preco;
        }
    }
}