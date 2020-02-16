namespace board {
    class Board {
        public int Rows { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;

        public Board(int rows, int columns) {
            Rows = rows;
            Columns = columns;
            Pieces = new Piece[rows, columns];

        }  

        public Piece Piece(int row, int column) {
            return Pieces[row, column];

        }

        public Piece Piece(Position pos) {
            return Pieces[pos.Row, pos.Column];

        }

        public bool PieceExist(Position pos) {
            CheckPosition(pos);
            return Piece(pos) != null;

        }

        public void InsertPiece(Piece p, Position pos) {
            if (PieceExist(pos)) {
                throw new BoardException("Já existe uma peça nessa posição.");

            }

            Pieces[pos.Row, pos.Column] = p;
            p.Position = pos;

        }

        public Piece RemovePiece(Position pos) {
            if (Piece(pos) == null) {
                return null;

            }

            Piece aux = Piece(pos);
            aux.Position = null;
            Pieces[pos.Row, pos.Column] = null;

            return aux;

        }

        public bool PositionIsOk(Position pos) {
            if (pos.Row < 0 || pos.Row >= Rows || pos.Column < 0 || pos.Column >= Columns) {
                return false;

            }

            return true;

        }

        public void CheckPosition(Position pos) {
            if (!PositionIsOk(pos)) {
                throw new BoardException("Posição inválida.");

            }

        }

    }
}
