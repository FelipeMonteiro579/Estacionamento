using SistemaEstacionamento.Models;

namespace SistemaEstacionamento
{
    public class Program : Sistema
    {
        static void Main(string[] args)
        {
            byte opcao = 0;

            Sistema sistema = new();

            Veiculo veiculo = new();
            List<Veiculo> veiculos = new();

            Console.WriteLine("Antes de iniciar defina os seguintes valores para o estacionamento:");
            sistema.CobrarValorInicial();
            sistema.CobrarValorPorHora();

            do 
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Lista de opcoes:");
                Console.WriteLine("================================");

                Console.WriteLine("Opcao 1 : Adicionar veiculo");
                Console.WriteLine("Opcao 2 : Listar veiculos");
                Console.WriteLine("Opcao 3 : Remover veiculo");
                Console.WriteLine("Opcao 4 : Encerrar programa!");

                Console.WriteLine("\n================================\n");
                Console.WriteLine("Insira a opcao desejada: ");
                opcao = Byte.Parse(Console.ReadLine()!);
                Console.WriteLine("\n================================\n");

                if (opcao == 4)
                {
                    if (veiculos.Any())
                    {
                        Console.WriteLine("Ainda existem veiculos no estacionamento, ainda nao eh possivel enncerrar o programa.");
                        opcao = 2;
                    }
                }

                switch (opcao)
                {
                    case 1:
                        {
                            Console.WriteLine("Voce selecionou adicionar veiculo:");
                            sistema.AdicionarVeiculo(veiculos);
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Voce selecionou listar veiculos:");
                            sistema.ListarVeiculos(veiculo, veiculos);
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("Voce selecionou remover veiculo:");
                            sistema.RemoverVeiculo(veiculo, veiculos);
                        }
                        break;

                    case 4:
                        {
                            Console.WriteLine("Vooce selecionou encerrar o programa.");
                            Console.ReadKey();
                        }
                        break;

                    default:
                        Console.WriteLine("Opcao nao encontrada.");
                        break;
                }
            } while (opcao != 4);

            Console.Clear();

            Console.WriteLine("====================================");
            Console.WriteLine("Fim do Programa!");
            Console.WriteLine("====================================");
        }
    }
}
