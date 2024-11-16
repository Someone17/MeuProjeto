using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Script : MonoBehaviour
{
    public Transform playerPaddle;
    public Transform player2Paddle;

    public BallMovement ballMovement;

    public int player1Score = 0;
    public int player2Score =0;

    public TextMeshProUGUI textPointsPlayer1;
    public TextMeshProUGUI textPointsPlayer2;

    
    void Start(){
        ResetGame();
    }
    public void ResetGame(){
        playerPaddle.position = new Vector3(4.92f, 0f, 0f);
        player2Paddle.position = new Vector3(-4.85f, -0.02f, -0.1050238f);
    
        ballMovement.ResetBall();

        player1Score = 0;
        player2Score = 0;

        textPointsPlayer1.text = player1Score.ToString();
        textPointsPlayer2.text = player2Score.ToString();
    }

    public void ScorePlayer1(){
        player1Score++;
        textPointsPlayer1.text = player1Score.ToString();
    }

    public void ScorePlayer2(){
        player2Score++;
        textPointsPlayer2.text = player2Score.ToString();
    }
}