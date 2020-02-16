using System;
using Board;

namespace XadrezConsole {
    class Program {
        static void Main(string[] args) {

            //padrao de camadas - tabuleiro, jogo de xadrez, aplicação
            Position P;

            P = new Position(3, 4);

            Console.WriteLine(P);
        }
    }
}
