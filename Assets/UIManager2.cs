using UnityEngine;
using UnityEngine.UI;

public class UIManager2 : MonoBehaviour
{
    public Text player1ScoreText;
    public Text player2ScoreText;
    public Text winMessageText;

    public void UpdateScoreUI(int playerNumber, int score)
    {
        if (playerNumber == 1)
        {
            player1ScoreText.text = "Player 1 Score: " + score;
        }
        else if (playerNumber == 2)
        {
            player2ScoreText.text = "Player 2 Score: " + score;
        }
    }

    public void DisplayWinMessage(string message)
    {
        winMessageText.text = message;
        // Optionally, add logic to stop the game or display a restart button
    }
}
