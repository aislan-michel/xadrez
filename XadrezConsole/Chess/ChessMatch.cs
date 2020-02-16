using System;
using board;

namespace chess {
    class ChessMatch {
        public Board board { get; private set; }
        private int Turn;
        private Color AtualPlayer;
        public bool Finish { get; private set; }

        public ChessMatch() {
            board = new Board(8, 8);
            Turn = 1;
            AtualPlayer = Color.Branca;
            Finish = false;
            InsertPieces();

        }

        public void Move(Position o, Position d) {
            Piece p = board.RemovePiece(o);
            p.IncrementMoves();
            Piece Catch = board.RemovePiece(d);
            board.InsertPiece(p, d);

        }

        private void InsertPieces() {
            board.InsertPiece(new Tower(board, Color.Branca), new ChessPosition('c', 1).ToPosition());
            board.InsertPiece(new Tower(board, Color.Branca), new ChessPosition('c', 2).ToPosition());
            board.InsertPiece(new Tower(board, Color.Branca), new ChessPosition('d', 2).ToPosition());
            board.InsertPiece(new Tower(board, Color.Branca), new ChessPosition('e', 2).ToPosition());
            board.InsertPiece(new Tower(board, Color.Branca), new ChessPosition('e', 1).ToPosition());

            board.InsertPiece(new King(board, Color.Branca), new ChessPosition('d', 1).ToPosition());

            board.InsertPiece(new Tower(board, Color.Preta), new ChessPosition('c', 7).ToPosition());
            board.InsertPiece(new Tower(board, Color.Preta), new ChessPosition('c', 8).ToPosition());
            board.InsertPiece(new Tower(board, Color.Preta), new ChessPosition('d', 7).ToPosition());
            board.InsertPiece(new Tower(board, Color.Preta), new ChessPosition('e', 7).ToPosition());
            board.InsertPiece(new Tower(board, Color.Preta), new ChessPosition('e', 8).ToPosition());

            board.InsertPiece(new King(board, Color.Preta), new ChessPosition('d', 8).ToPosition());

        }

    }
}
