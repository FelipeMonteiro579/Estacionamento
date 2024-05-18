
namespace SistemaEstacionamento.Models
{
    public class Estacionamento : Veiculo
    {
        private float _valorInicial;
        private float _valorPorHora;

        #region "Getters e Setters"
        public float ValorInicial
        {
            get { return _valorInicial; }
            set { _valorInicial = value; }
        }

        public float ValorPorHora
        {
            get { return _valorPorHora;}
            set { _valorPorHora = value;}
        }
        #endregion

        public void CobrarValorInicial()
        {
            Console.WriteLine("Insira o valor inicial do estacionamento:");
            ValorInicial = short.Parse(Console.ReadLine()!);
        }

        public void CobrarValorPorHora()
        {
            Console.WriteLine("Insira o valor cobrado por hora:");
            ValorPorHora = short.Parse(Console.ReadLine()!);
        }

        public void CalcularValorFinalEstacionamento(TimeSpan tempoPermanencia, Veiculo veiculo)
        {
            float valorFinal = (ValorInicial + (ValorPorHora * tempoPermanencia.Hours));
            Console.WriteLine($"Total a pagar: {(Math.Round(valorFinal,2)).ToString("C")}");
            Console.WriteLine($"Tempo de permanencia: {tempoPermanencia}");
            Console.ReadKey();
        }
    }
}
