using System;
using board;
using chess;

namespace ChessConsole {
    class Program {
        static void Main(string[] args) {
            //padrao de camadas - tabuleiro, jogo de xadrez, aplicação
            try {
                Board board = new Board(8, 8);

                board.InsertPiece(new Tower(board, Color.Preta), new Position(0, 0));
                board.InsertPiece(new Tower(board, Color.Preta), new Position(1, 3));
                board.InsertPiece(new King(board, Color.Preta), new Position(0, 2));

                board.InsertPiece(new Tower(board, Color.Branca), new Position(3, 5));

                Screen.printTray(board);

            } catch (BoardException e) {
                Console.WriteLine(e.Message);

            }

        }
    }
}
