namespace Aula16Construtores
{
    public class Produto
    {        
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }

        public Produto(){

        }

        public Produto(int _codigo){
            this.Codigo = _codigo;
        }

        public Produto(int _codigo, string _nome, string _descricao, int _estoque){

            this.Codigo     = _codigo;
            this.Nome       = _nome;
            this.Descricao  = _descricao;
            this.Estoque    = _estoque;

        }

    }
}