using System;
using board;

namespace XadrezConsole {
    class Program {
        static void Main(string[] args) {
            //padrao de camadas - tabuleiro, jogo de xadrez, aplicação
            Board board = new Board(8, 8);

            Screen.printTray(board);

        }
    }
}
