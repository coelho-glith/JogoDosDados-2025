namespace JogoDosDados.ConsoleApp
{
    /** Versão 1 - Estrutura básica e simulação de dados
      * Exibir um banner para o jogo de dados [x]
      * Permitir que o usuário pressione Enter para lançar o dado
      * Implementar a geração de números aleatórios para simular um dado (1-6) [x]
      * Exibir o resultado do lançamento do dado  
    **/
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Jogo dos Dados Divertido");
                Console.WriteLine("----------------------------------");

                Console.Write("Pressione ENTER para lançar o dado...");
                Console.ReadLine();

                Random geradorDeNumeros = new Random();

                int resultado = geradorDeNumeros.Next(1, 7);

                Console.WriteLine("----------------------------------");
                Console.WriteLine($"O valor sorteado foi: {resultado}!");
                Console.WriteLine("----------------------------------");

                Console.Write("Deseja continuar? (s/N) ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}