namespace Aula09Calculadora
{
    public class Calculadora
    {
        public float num1 { get; set; }
        public float num2 { get; set; }
        public float resultado { get; set; }
        public string operador { get; set; }

        public void Somar(){
            resultado = num1 + num2;
        }

        public void Subtrair(){
            resultado = num1 - num2;
        }

        public void Multiplicar(){
            resultado = num1 * num2;
        }

        public void Dividir(){
            resultado = num1 / num2;
        }



    }
}