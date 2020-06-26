namespace Aula22Static
{
    public static class Conversor
    {

        public static float CotacaoDolar = 5.30f;

        public static float ConverterDolarParaReal(float valor){
            return valor * CotacaoDolar;
        }

        public static float ConverterRealParaDolar(float valor){
            return valor / CotacaoDolar;
        }

    }
}