
namespace SistemaEstacionamento.Models
{
    public class Sistema : Estacionamento
    {
        public void AdicionarVeiculo(List<Veiculo> grupoVeiculos)
        {
            Veiculo veiculo = new Veiculo();

            Console.WriteLine("\nInsira a placa do veiculo:");
            veiculo.Placa = Console.ReadLine()!;

            veiculo.HoraInicio = DateTime.Now;

            grupoVeiculos.Add(veiculo);
        }

        public void ListarVeiculos(Veiculo veiculo, List<Veiculo>grupoVeiculos) 
        {
            Console.WriteLine("\nLISTA DE VEICULOS:\n");

            for (int i = 0; i < grupoVeiculos.Count; i++)
            {
                Console.WriteLine($"{i} - {grupoVeiculos[i].Placa} ({grupoVeiculos[i].HoraInicio})");
            }

            Console.WriteLine("==========================");
        }

        public void RemoverVeiculo(Veiculo veiculo, List<Veiculo> grupoVeiculos)
        {
            short escolhaIndice = 0;
            string placaVeiculo = string.Empty;

            TimeSpan tempoPermanencia;

            ListarVeiculos(veiculo, grupoVeiculos);

            try
            {
                Console.WriteLine("Insira o indice do veiculo que deseja remover:");
                escolhaIndice = short.Parse(Console.ReadLine()!);
            } catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            if (grupoVeiculos.Contains(grupoVeiculos[escolhaIndice]))
            {
                Console.WriteLine("Veiculo encontrado com sucesso! Para realizar a remocao do veiculo, digite a placa: ");
                placaVeiculo = Console.ReadLine()!;

                if (placaVeiculo.ToUpper() == grupoVeiculos[escolhaIndice].Placa.ToUpper())
                {
                    grupoVeiculos[escolhaIndice].HoraFinal = DateTime.Now;
                    tempoPermanencia = grupoVeiculos[escolhaIndice].HoraFinal.Subtract(grupoVeiculos[escolhaIndice].HoraInicio);

                    CalcularValorFinalEstacionamento(tempoPermanencia, veiculo);

                    grupoVeiculos.Remove(grupoVeiculos[escolhaIndice]);
                }
                else
                {
                    Console.WriteLine("Valor inserido incorreto.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Veiculo nao encontrado!");
            }


        }
    }
}
