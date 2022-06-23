using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int score1;
    public int score2;
    public int score3;
    public int score4;
    public int maxScore;

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public GameObject tembok1;
    public GameObject tembok2;
    public GameObject tembok3;
    public GameObject tembok4;

    public GameObject winnerText;
    public GameObject skor;

    private int playerCounter;

    public void AddScore1(int increment)
    {
        score1 += increment;

        if (score1 >= maxScore)
        {
            player1.GetComponent<PlayerController>().PlayerDead();
            playerCounter += 1;
        }
    }

    public void AddScore2(int increment)
    {
        score2 += increment;

        if (score2 >= maxScore)
        {
            player2.GetComponent<PlayerController>().PlayerDead();
            tembok2.SetActive(true);
            playerCounter += 1;
        }
    }

    public void AddScore3(int increment)
    {
        score3 += increment;

        if (score3 >= maxScore)
        {
            player3.GetComponent<PlayerController>().PlayerDead();
            tembok3.SetActive(true);
            playerCounter += 1;
            Debug.Log("player nambah 1");
        }
    }

    public void AddScore4(int increment)
    {
        score4 += increment;

        if (score4 >= maxScore)
        {
            player4.GetComponent<PlayerController>().PlayerDead();
            tembok4.SetActive(true);
            playerCounter += 1;
        }
    }

    public void GameOver()
    {
        if (playerCounter >= 3)
        {
            Time.timeScale = 0;
            winnerText.SetActive(true);
            skor.SetActive(false);
        }
    }

    private void Update()
    {
        GameOver();
    }
}
