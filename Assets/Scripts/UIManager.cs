using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{

    public io.newgrounds.core ngio_core;

    public int score;
    public Text textScore;
    bool GameOver;
    public Button []btn;

    void unlockMedal(int medal_id) {
        io.newgrounds.components.Medal.unlock medal_unlock = new io.newgrounds.components.Medal.unlock();
        medal_unlock.id = medal_id;
        medal_unlock.callWith(ngio_core, onMedalUnlocked);
    }

    // this will get called whenever a medal gets unlocked via unlockMedal()
    void onMedalUnlocked(io.newgrounds.results.Medal.unlock result) {
        io.newgrounds.objects.medal medal = result.medal;
        Debug.Log( "Medal Unlocked: " + medal.name + " (" + medal.value + " points)" );
    }

    public void SubmitScore(int score_id, int score){
        io.newgrounds.components.ScoreBoard.postScore submit_score = new io.newgrounds.components.ScoreBoard.postScore();
        submit_score.id = score_id;
        submit_score.value = score;
        submit_score.callWith(ngio_core);
        Debug.Log("Score Submited!");
    }

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
                SubmitScore(12309, score);
                if(score == 5){
                    unlockMedal(71695);
                }
                if(score == 10){
                    unlockMedal(71696);
                }
                if(score == 15){
                    unlockMedal(71697);
                }
                if(score == 20){
                    unlockMedal(71698);
                }
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
        unlockMedal(71694);
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
