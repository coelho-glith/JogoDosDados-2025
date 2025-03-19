namespace JogoDosDados.ConsoleApp
{
    /** Versão 2 - Controle de posição do jogador
      * Armazenar a posição do jogador na pista e atualizar o valor após o lançamento do dado
      * Exibir a posição atual do jogador na pista
      * Definir a linha de chegada em 30 verificar se o jogador alcançou ou ultrapassou a linha de chegada
      * Permitir o jogador realizar várias jogadas
    **/
    internal class Program
    {
        static void Main(string[] args)
        {
            const int limiteLinhaChegada = 30;

            while (true)
            {
                int posicaoJogador = 0;
                bool jogoEmAndamento = true;

                while (jogoEmAndamento)
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Jogo dos Dados");
                    Console.WriteLine("----------------------------------");

                    Console.Write("Pressione ENTER para lançar o dado...");
                    Console.ReadLine();

                    Random geradorDeNumeros = new Random();

                    int resultado = geradorDeNumeros.Next(1, 7);

                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"O valor sorteado foi: {resultado}!");
                    Console.WriteLine("----------------------------------");

                    posicaoJogador += resultado;

                    if (posicaoJogador >= limiteLinhaChegada)
                    {
                        jogoEmAndamento = false;

                        Console.WriteLine("Parabéns! Você alcançou a linha de chegada!");
                    }
                    else
                        Console.WriteLine($"Você está na posição: {posicaoJogador} de {limiteLinhaChegada}!");

                    Console.WriteLine("----------------------------------");
                    Console.ReadLine();
                }

                Console.Write("Deseja continuar? (s/N) ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}