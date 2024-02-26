using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int player1Score = 0;
    public int player2Score = 0;

    public UIManager2 uiManager;

    public void UpdateScore(string playerName)
    {
        if (playerName == "Player1")
        {
            player1Score++;
            uiManager.UpdateScoreUI(1, player1Score);
        }
        else if (playerName == "Player2")
        {
            player2Score++;
            uiManager.UpdateScoreUI(2, player2Score);
        }

        CheckWinCondition();
    }

    private void CheckWinCondition()
    {
        if (player1Score >= 4)
        {
            uiManager.DisplayWinMessage("Player 1 Wins!");
        }
        else if (player2Score >= 4)
        {
            uiManager.DisplayWinMessage("Player 2 Wins!");
        }
    }
}

