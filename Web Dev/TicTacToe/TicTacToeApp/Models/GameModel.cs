public class GameModel
{
    public char[] Board { get; set; } // represents the 3x3 game board as a char array
    public char WhoseTurn { get; set; } // indicates whose turn it is, either 'X' or 'O'
    public bool GameOver { get; set; } // indicates if the game is over or not
    public char Winner { get; set; } // indicates the winner, either 'X' or 'O', or ' ' if there is no winner

    public GameModel()
    {
        // initialize the game board with blank spaces
        Board = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        WhoseTurn = 'X'; // by default, X goes first
        GameOver = false;
        Winner = ' '; // there is no winner yet
    }
}
