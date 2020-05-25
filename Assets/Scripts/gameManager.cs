using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject player1Text;
    public GameObject player2Text;

    private int Player1Score = 0;
    private int Player2Score = 0;

    public void player1Scored()
    {
        Player1Score++;
        player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        RestPosition();
    }

    public void player2Scored()
    {
        Player2Score++;
        player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        RestPosition();
    }

    private void RestPosition()
    {
        ball.GetComponent<ball>().Reset();
        player1Paddle.GetComponent<paddle>().Reset();
        player2Paddle.GetComponent<paddle>().Reset();
    }
}
