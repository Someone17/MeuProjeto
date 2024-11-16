using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform playerPaddle;
    public Transform player2Paddle;

    public BallMovement ballMovement;

    public int player1Score = 0;
    public int player2Score =0;

    public int winPoints;

    public TextMeshProUGUI textPointsPlayer1;
    public TextMeshProUGUI textPointsPlayer2;

    public GameObject screenEndGame;

    public TextMeshProUGUI textEndGame;

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

        screenEndGame.SetActive(false);
    }

    public void ScorePlayer1(){
        player1Score++;
        textPointsPlayer1.text = player1Score.ToString();
        CheckWin();
    }

    public void ScorePlayer2(){
        player2Score++;
        textPointsPlayer2.text = player2Score.ToString();
        CheckWin();
    }

    public void CheckWin(){
        if(player1Score >= winPoints || player2Score >= winPoints){
            /*ResetGame();*/
            EndGame();
        }
    }
    
    public void EndGame(){
        screenEndGame.SetActive(true);
        string winner = SaveController.Instance.GetName(player1Score > player2Score);
        textEndGame.text = "Vitoria " + winner;
        SaveController.Instance.SaveWinner(winner);
        Invoke("LoadMenu", 2f);
    }

    private void LoadMenu(){
        SceneManager.LoadScene("Menu Scene");
    }
}
