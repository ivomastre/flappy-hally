using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void increaseScore(int amount = 1)
    {
        playerScore = playerScore + amount;
        scoreText.text = playerScore.ToString();
    }

}
