using System;
using board;
using chess;

namespace ChessConsole {
    class Program {
        static void Main(string[] args) {
            //padrao de camadas - tabuleiro, jogo de xadrez, aplicação
            try {
                ChessPosition pos = new ChessPosition('c', 7);

                Console.WriteLine(pos);

                Console.WriteLine(pos.ToPosition());

            } catch (BoardException e) {
                Console.WriteLine(e.Message);

            }

        }
    }
}
