using System;
using board;
using xadrez;

namespace XadrezConsole {
    class Program {
        static void Main(string[] args) {
            //padrao de camadas - tabuleiro, jogo de xadrez, aplicação
            Board board = new Board(8, 8);

            board.InsertPiece(new Tower(board, Color.Preta), new Position(0, 0));
            board.InsertPiece(new Tower(board, Color.Preta), new Position(1, 3));
            board.InsertPiece(new King(board, Color.Preta), new Position(2, 4));

            Screen.printTray(board);



            Console.ReadLine();

        }
    }
}
