using System;
using board;
using chess;

namespace ChessConsole {
    class Program {
        static void Main(string[] args) {
            //padrao de camadas - tabuleiro, jogo de xadrez, aplicação
            try {
                ChessMatch match = new ChessMatch();

                while (!match.Finish) {
                    Console.Clear();
                    Screen.printTray(match.board);

                    Console.Write("\nOrigem: ");
                    Position origin = Screen.ReadChessPosition().ToPosition();

                    Console.Write("\nDestino: ");
                    Position destiny = Screen.ReadChessPosition().ToPosition();

                    match.Move(origin, destiny);

                }




            } catch (BoardException e) {
                Console.WriteLine(e.Message);

            }

        }
    }
}
