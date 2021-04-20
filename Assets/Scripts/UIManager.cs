using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{

    int score;
    public Text textScore;
    bool GameOver;
    public Button []btn;

    // Start is called before the first frame update
    void Start()
    {
        GameOver = false;
        score = 0;
        InvokeRepeating("UpdateScore", 1f, 0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        if (textScore != null)
        textScore.text = "Score:" + score;
    }
        void UpdateScore()
        {
            if (!GameOver)
            {
                score++;
            }
        }

    public void gameOver()
    {
        GameOver = true;
        foreach(Button but in btn)
        {
            but.gameObject.SetActive(true);
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
