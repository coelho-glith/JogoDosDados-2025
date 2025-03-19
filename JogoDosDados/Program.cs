namespace JogoDosDados.ConsoleApp
{
    /** Versão 3 - Eventos Especiais: Avanço extra e Recuo
      * Implementar o evento de avanço extra nas posições 5, 10, 15, 25
      * Implementar o evento de recuo nas posições 7, 13, 20
      * Exibir mensagens informativas quando os eventos ocorrerem
      * Atualizar a posição do jogador conforme as regras dos eventos 
      * Exibir a nova posição
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

                    Console.WriteLine($"Você está na posição: {posicaoJogador} de {limiteLinhaChegada}!");

                    if (posicaoJogador == 5 || posicaoJogador == 10 || posicaoJogador == 15 || posicaoJogador == 25)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");

                        posicaoJogador += 3;

                        Console.WriteLine($"Você avançou para a posição: {posicaoJogador}!");
                    }
                    else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");

                        posicaoJogador -= 2;

                        Console.WriteLine($"Você recuou para a posição: {posicaoJogador}!");
                    }

                    if (posicaoJogador >= limiteLinhaChegada)
                    {
                        jogoEmAndamento = false;

                        Console.WriteLine("Parabéns! Você alcançou a linha de chegada!");
                    }   

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