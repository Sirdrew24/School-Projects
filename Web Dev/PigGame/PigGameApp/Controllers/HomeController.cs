using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PigGameApp.Models;
using System.Diagnostics;

namespace PigGameApp.Controllers
{
    public class HomeController : Controller
    {
        const int AMOUNT_TO_WIN = 20;

        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("Player1Score", 0);
            HttpContext.Session.SetInt32("Player2Score", 0);
            HttpContext.Session.SetInt32("TurnTotal", 0);
            HttpContext.Session.SetInt32("DieValue", 0);
            HttpContext.Session.SetString("PlayerTurn", "Player1");
            ViewBag.DisableRollAndHold = null;
            ViewBag.Winner = null;

            var model = new PigGameModel
            {
                Player1Score = HttpContext.Session.GetInt32("Player1Score") ?? 0,
                Player2Score = HttpContext.Session.GetInt32("Player2Score") ?? 0,
                TurnTotal = HttpContext.Session.GetInt32("TurnTotal") ?? 0,
                DieValue = HttpContext.Session.GetInt32("DieValue") ?? 0
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Roll()
        {
            Random rand = new Random();
            int roll = rand.Next(1, 7);

            HttpContext.Session.SetInt32("DieValue", roll);

            if (roll == 1)
            {
                HttpContext.Session.SetInt32("TurnTotal", 0);
                var model = new PigGameModel
                {
                    Player1Score = HttpContext.Session.GetInt32("Player1Score") ?? 0,
                    Player2Score = HttpContext.Session.GetInt32("Player2Score") ?? 0,
                    TurnTotal = 0,
                    DieValue = roll
                };
                return View("Index", model);
            }
            else
            {
                int turnTotal = HttpContext.Session.GetInt32("TurnTotal") ?? 0;
                turnTotal += roll;
                HttpContext.Session.SetInt32("TurnTotal", turnTotal);

                var model = new PigGameModel
                {
                    Player1Score = HttpContext.Session.GetInt32("Player1Score") ?? 0,
                    Player2Score = HttpContext.Session.GetInt32("Player2Score") ?? 0,
                    TurnTotal = turnTotal,
                    DieValue = roll
                };

                return View("Index", model);
            }          
        }

        [HttpPost]
        public IActionResult Hold()
        {
            int turnTotal = HttpContext.Session.GetInt32("TurnTotal") ?? 0;
            int playerScore = 0;
            string playerTurn = HttpContext.Session.GetString("PlayerTurn");

            if (playerTurn == "Player1")
            {
                playerScore = HttpContext.Session.GetInt32("Player1Score") ?? 0;
                playerScore += turnTotal;
                HttpContext.Session.SetInt32("Player1Score", playerScore);

                if (playerScore >= AMOUNT_TO_WIN)
                {
                    ViewBag.Winner = "Player 1";
                    ViewBag.DisableRollAndHold = "disabled";
                }
                else
                {
                    HttpContext.Session.SetString("PlayerTurn", "Player2");
                }
            }
            else
            {
                playerScore = HttpContext.Session.GetInt32("Player2Score") ?? 0;
                playerScore += turnTotal;
                HttpContext.Session.SetInt32("Player2Score", playerScore);

                if (playerScore >= AMOUNT_TO_WIN)
                {
                    ViewBag.Winner = "Player 2";
                    ViewBag.DisableRollAndHold = "disabled";
                }
                else
                {
                    HttpContext.Session.SetString("PlayerTurn", "Player1");
                }
            }

            HttpContext.Session.SetInt32("TurnTotal", 0);

            var model = new PigGameModel
            {
                Player1Score = HttpContext.Session.GetInt32("Player1Score") ?? 0,
                Player2Score = HttpContext.Session.GetInt32("Player2Score") ?? 0,
                TurnTotal = HttpContext.Session.GetInt32("TurnTotal") ?? 0,
                DieValue = HttpContext.Session.GetInt32("DieValue") ?? 0
            };

            return View("Index", model);
        }
    }
}