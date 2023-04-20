using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    private GameModel _gameModel; // create a private instance of the GameModel class

    public HomeController()
    {
        _gameModel = new GameModel(); // initialize the game model
    }

    public ActionResult Index()
    {
        return View(_gameModel); // pass the game model to the view
    }

    [HttpPost]
    public ActionResult Index(int buttonIndex)
    {
        Console.WriteLine($"buttonIndex recieved: {0}", buttonIndex);

        if (!_gameModel.GameOver && _gameModel.Board[buttonIndex] == ' ')
        {
            // update the game model with the player's move
            _gameModel.Board[buttonIndex] = _gameModel.WhoseTurn;
            _gameModel.WhoseTurn = _gameModel.WhoseTurn == 'X' ? 'O' : 'X'; // switch to the other player's turn

            Console.WriteLine($"board array updated: {0}", string.Join(",", _gameModel.Board));

            // check for a winner or tie
            char winner = CheckForWinner();
            if (winner != ' ')
            {
                _gameModel.GameOver = true;
                _gameModel.Winner = winner;
            }
            else if (IsTie())
            {
                _gameModel.GameOver = true;
            }
        }

        return View(_gameModel); // pass the updated game model to the view
    }

    private char CheckForWinner()
    {
        // check for three in a row horizontally
        for (int i = 0; i < 3; i++)
        {
            if (_gameModel.Board[i * 3] != ' ' && _gameModel.Board[i * 3] == _gameModel.Board[i * 3 + 1] && _gameModel.Board[i * 3 + 1] == _gameModel.Board[i * 3 + 2])
            {
                return _gameModel.Board[i * 3];
            }
        }

        // check for three in a row vertically
        for (int i = 0; i < 3; i++)
        {
            if (_gameModel.Board[i] != ' ' && _gameModel.Board[i] == _gameModel.Board[i + 3] && _gameModel.Board[i + 3] == _gameModel.Board[i + 6])
            {
                return _gameModel.Board[i];
            }
        }

        // check for three in a row diagonally
        if (_gameModel.Board[0] != ' ' && _gameModel.Board[0] == _gameModel.Board[4] && _gameModel.Board[4] == _gameModel.Board[8])
        {
            return _gameModel.Board[0];
        }
        if (_gameModel.Board[2] != ' ' && _gameModel.Board[2] == _gameModel.Board[4] && _gameModel.Board[4] == _gameModel.Board[6])
        {
            return _gameModel.Board[2];
        }

        // no winner yet
        return ' ';
    }

    private bool IsTie()
    {
        // check if all spaces are filled
        for (int i = 0; i < 9; i++)
        {
            if (_gameModel.Board[i] == ' ')
            {
                return false;
            }
        }

        // it's a tie
        return true;
    }
}
