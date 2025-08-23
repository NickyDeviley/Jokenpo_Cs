using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    public class main
    {

        public static Random sorteador = new Random();

        public static void Main(String[] args)
        {

            // Jokenpo - Jogo do Pedra, Papel e Tesoura

            int escolhaUsuario = 0;

            Console.WriteLine("Bem-vindo ao Jokenpo!");

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Pedra \n2 = Papel \n3 - Tesoura");

            escolhaUsuario = Convert.ToInt32(Console.ReadLine());

            if (escolhaUsuario < 1 || escolhaUsuario > 3)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                return;
            }

            int escolhaComputador = sorteador.Next(1, 4); // Gera um número aleatório entre 1 e 3

            if (escolhaUsuario == escolhaComputador)
            {
                Console.WriteLine("Empate! Ambos escolheram a mesma opção.");
            }
            else
            {

                if (escolhaComputador == 1 && escolhaUsuario == 2)
                {
                    metodos.mensagemV(escolhaComputador, escolhaUsuario);
                }
                else if (escolhaComputador == 2 && escolhaUsuario == 3)
                {
                    metodos.mensagemV(escolhaComputador, escolhaUsuario);
                }
                else if (escolhaComputador == 3 && escolhaUsuario == 1)
                {
                    metodos.mensagemV(escolhaComputador, escolhaUsuario);
                }
                else if (escolhaComputador == 1 && escolhaUsuario == 3)
                {
                    metodos.mensagemD(escolhaComputador, escolhaUsuario);
                }
                else if (escolhaComputador == 2 && escolhaUsuario == 1)
                {
                    metodos.mensagemD(escolhaComputador, escolhaUsuario);
                }
                else if (escolhaComputador == 3 && escolhaUsuario == 2)
                {
                    metodos.mensagemD(escolhaComputador, escolhaUsuario);

                }
            }
        }
    }
}
