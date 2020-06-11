using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instanciamos o passageiro
            Passageiro passageiro = new Passageiro();

            System.Console.WriteLine("Digite seu login:");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha:");
            string senha = Console.ReadLine();

            passageiro.Login(login, senha);

            if( passageiro.TokenLogin != "" && passageiro.TokenLogin != null ){
                
                System.Console.WriteLine("Login autorizado!");
                
                // Instanciamos um motorista para teste
                Motorista motorista = new Motorista();
                motorista.Nome = "Alexandre";
                motorista.Placa = "XPTO-3548";
                motorista.Carro = "Ford Mustang";

                // Cadastramos uma conta para o motorista
                Conta contaMotorista = new Conta();
                contaMotorista.Cadastrar();

                // Atribuímos dados do passageiro                
                passageiro.Nome = "Paulo Brandao";
                passageiro.Idade = 30;
                passageiro.LocalizacaoAtual = "Rua 15 de piracicaba, 456";


                // Salvamos um cartão para o usuário
                Cartao cartao = new Cartao();
                cartao.Cadastrar();

                passageiro.SolicitarMotorista();
                motorista.AceitarPassageiro(passageiro.Nome);

                // Começamos uma corrida
                Corrida corrida = new Corrida();
                corrida.LocalInicio = passageiro.LocalizacaoAtual;
                corrida.LocalChegada = "Av. Paulista, 123";
                corrida.motorista = motorista.Nome;
                corrida.passageiro = passageiro.Nome;

                string resposta = "Não chegamos";

                while(resposta != "Sim"){
                    Console.WriteLine("Você chegou ao seu destino? Digite: Sim ou Nao");
                    resposta = Console.ReadLine();
                }

                // Finalizamos a corrida
                corrida.StatusCorrida = "Finalizada";
                passageiro.Pagar(corrida.StatusCorrida);
                motorista.ReceberPagamento(corrida.StatusCorrida);

                // Realizamos o Pagamento
                Pagamento pgto = new Pagamento();
                pgto.Data = DateTime.Now;
                pgto.StatusPagamento = "Pago";

                Console.WriteLine("Corrida Finalizada");
                Console.WriteLine("Status Corrida: "+corrida.StatusCorrida);
                Console.WriteLine("Status PGTO: "+pgto.StatusPagamento);
                Console.WriteLine("Data e Hora: "+pgto.Data);
                Console.WriteLine("Motorista: "+motorista.Nome);



            }else{
                System.Console.WriteLine("Não é possível utilizar o app");
            }



        }
    }
}
