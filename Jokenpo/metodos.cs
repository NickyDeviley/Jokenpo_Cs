using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    internal class metodos
    {
        public static void mensagemV(int escolhaComputador, int escolhaUsuario)
        {
            Console.WriteLine("Você venceu!");
            Console.WriteLine("Computador escolheu: " + mensagemE(escolhaComputador));
            Console.WriteLine("Você escolheu: " + mensagemU(escolhaUsuario));
        }
        public static void mensagemD(int escolhaComputador, int escolhaUsuario)
        {
            Console.WriteLine("Você perdeu!");
            Console.WriteLine("Computador escolheu: " + mensagemE(escolhaComputador));
            Console.WriteLine("Você escolheu: " + mensagemU(escolhaUsuario));
        }

        public static string mensagemE(int escolhaComputador)
        {
            string escolhaC = "";

            if (escolhaComputador == 1)
            {
                escolhaC = "Pedra";
            }
            else if (escolhaComputador == 2)
            {
                escolhaC = "Papel";
            }
            else if (escolhaComputador == 3)
            {
                escolhaC = "Tesoura";
            }
            return escolhaC;
        }
        public static string mensagemU(int escolhaUsuario)
        {
            string escolhaU = "";
            if (escolhaUsuario == 1)
            {
                escolhaU = "Pedra";
            }
            else if (escolhaUsuario == 2)
            {
                escolhaU = "Papel";
            }
            else if (escolhaUsuario == 3)
            {
                escolhaU = "Tesoura";
            }
            return escolhaU;
        }

    }
}
