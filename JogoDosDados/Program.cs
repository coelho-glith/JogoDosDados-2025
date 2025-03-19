﻿namespace JogoDosDados.ConsoleApp
{
    /** Versão 4 - Incluir o computador como concorrente
      * Informar que o computador está jogando
      * Armazenar a posição do computador na pista e atualizar o valor após o lançamento do dado  
      * Atualizar a posição do computador após seu lançamento de dado
      * Implementar o evento de avanço extra nas posições 5, 10, 15
      * Implementar o evento de recuo nas posições 7, 13, 20
      * Exibir mensagens informativas quando os eventos ocorrerem
      * Atualizar a posição do jogador conforme as regras dos eventos 
      * Exibir a nova posição
      * Verificar se o computador alcançou ou ultrapassou a linha de chegada
      * Informar quem venceu o jogo
      * Implementar turnos alternados entre jogador e computador
    **/
    internal class Program
    {
        static void Main(string[] args)
        {
            const int limiteLinhaChegada = 30;

            while (true)
            {
                int posicaoUsuario = 0;
                int posicaoComputador = 0;

                bool jogoEmAndamento = true;

                while (jogoEmAndamento)
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Jogo dos Dados");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Rodada do Usuário");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Pressione ENTER para lançar o dado...");
                    Console.ReadLine();

                    int resultadoUsuario = SortearDado();

                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"O valor sorteado foi: {resultadoUsuario}!");
                    Console.WriteLine("----------------------------------");

                    posicaoUsuario += resultadoUsuario;

                    Console.WriteLine($"Você está na posição: {posicaoUsuario} de {limiteLinhaChegada}!");

                    if (posicaoUsuario == 5 || posicaoUsuario == 10 || posicaoUsuario == 15 || posicaoUsuario == 25)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");

                        posicaoUsuario += 3;

                        Console.WriteLine($"Você avançou para a posição: {posicaoUsuario}!");
                    }
                    else if (posicaoUsuario == 7 || posicaoUsuario == 13 || posicaoUsuario == 20)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");

                        posicaoUsuario -= 2;

                        Console.WriteLine($"Você recuou para a posição: {posicaoUsuario}!");
                        Console.WriteLine("-------------------------------------");
                    }



                    if (posicaoUsuario >= limiteLinhaChegada)
                    {

                        Console.WriteLine("Parabéns! Você alcançou a linha de chegada!");

                        jogoEmAndamento = false;
                        continue;
                    }

                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Rodada do Computador");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Pressione ENTER para visualizar a rodada do computador...");
                    Console.ReadLine();

                    int resultadoComputador = SortearDado();

                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"O valor sorteado foi: {resultadoComputador}!");
                    Console.WriteLine("----------------------------------");

                    posicaoComputador += resultadoComputador;

                    Console.WriteLine($"O computador está na posição: {posicaoComputador} de {limiteLinhaChegada}!");

                    if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15 || posicaoComputador == 25)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("EVENTO ESPECIAL: Avanço extra de 3 casas!");

                        posicaoComputador += 3;

                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine($"O computador avançou para a posição: {posicaoComputador}!");
                        Console.WriteLine("-------------------------------------");
                    }
                    else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("EVENTO ESPECIAL: Recuo de 2 casas!");

                        posicaoComputador -= 2;

                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine($"O computador recuou para a posição: {posicaoComputador}!");
                        Console.WriteLine("-------------------------------------");
                    }

                    if (posicaoComputador >= limiteLinhaChegada)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Que pena! O compuador alcançou a linha de chegada, tente novamente!");
                        Console.WriteLine("----------------------------------");

                        jogoEmAndamento = false;
                        continue;
                    }

                    Console.ReadLine();
                }

                Console.Write("Deseja continuar? (s/N) ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }

        static int SortearDado()
        {
            Random geradorDeNumeros = new Random();

            int resultado = geradorDeNumeros.Next(1, 7);

            return resultado;
        }
    }
}