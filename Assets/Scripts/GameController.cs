using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

using UnityEngine.SceneManagement;



public class GameController : MonoBehaviour

{

    public int totalScore;

    public Text scoreText;

    public GameObject gameOver;



    public static GameController instance;



    void Start()

    {

        instance = this;

    }



    public void UpdateScoreText()

    {

        scoreText.text = totalScore.ToString();

    }



    public void ShowGamerOver()

    {

        gameOver.SetActive(true);

    }



    public void RestartGame()

    {

        SceneManager.LoadScene("fase0");

    }

   

    public void RestartPhase()

    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}