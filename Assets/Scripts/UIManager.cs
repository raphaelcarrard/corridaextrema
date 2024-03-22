using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{

    public int score;
    public Text textScore;
    bool GameOver;
    public Button []btn;
    public bool medal1, medal2, medal3, medal4;
    public bool medal5, medal6, medal7, medal8;
    public bool medal9, medal10, medal11, medal12;
    public bool medal13, medal14, medal15, medal16;
    public bool medal17, medal18, medal19, medal20, medal21;

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
                if(score >= 5 && medal1 == false){
                    NGHelper.instance.unlockMedal(71695);
                    medal1 = true;
                }
                if(score >= 10 && medal2 == false){
                    NGHelper.instance.unlockMedal(71696);
                    medal2 = true;
                }
                if(score >= 15 && medal3 == false){
                    NGHelper.instance.unlockMedal(71697);
                    medal3 = true;
                }
                if(score >= 20 && medal4 == false){
                    NGHelper.instance.unlockMedal(71698);
                    medal4 = true;
                }
                if(score >= 30 && medal5 == false){
                    NGHelper.instance.unlockMedal(77909);
                    medal5 = true;
                }
                if(score >= 40 && medal6 == false){
                    NGHelper.instance.unlockMedal(77910);
                    medal6 = true;
                }
                if(score >= 50 && medal7 == false){
                    NGHelper.instance.unlockMedal(77911);
                    medal7 = true;
                }
                if(score >= 60 && medal8 == false){
                    NGHelper.instance.unlockMedal(77912);
                    medal8 = true;
                }
                if(score >= 70 && medal9 == false){
                    NGHelper.instance.unlockMedal(77913);
                    medal9 = true;
                }
                if(score >= 100 && medal10 == false){
                    NGHelper.instance.unlockMedal(77914);
                    medal10 = true;
                }
                if(score >= 125 && medal11 == false){
                    NGHelper.instance.unlockMedal(77915);
                    medal11 = true;
                }
                if(score >= 150 && medal12 == false){
                    NGHelper.instance.unlockMedal(77916);
                    medal12 = true;
                }
                if(score >= 175 && medal13 == false){
                    NGHelper.instance.unlockMedal(77917);
                    medal13 = true;
                }
                if(score >= 200 && medal14 == false){
                    NGHelper.instance.unlockMedal(77918);
                    medal14 = true;
                }
                if(score >= 225 && medal15 == false){
                    NGHelper.instance.unlockMedal(77919);
                    medal15 = true;
                }
                if(score >= 250 && medal16 == false){
                    NGHelper.instance.unlockMedal(77920);
                    medal16 = true;
                }
                if(score >= 275 && medal17 == false){
                    NGHelper.instance.unlockMedal(77921);
                    medal17 = true;
                    }
                if(score >= 300 && medal18 == false){
                    NGHelper.instance.unlockMedal(77922);
                    medal18 = true;
                }
                if(score >= 350 && medal19 == false){
                    NGHelper.instance.unlockMedal(77923);
                    medal19 = true;
                }
                if(score >= 400 && medal20 == false){
                    NGHelper.instance.unlockMedal(77924);
                    medal20 = true;
                }
                if(score >= 500 && medal21 == false){
                    NGHelper.instance.unlockMedal(77925);
                    medal21 = true;
                }
            }
        }

    public void gameOver()
    {
        NGHelper.instance.NGSubmitScore(12309, score);
        GameOver = true;
        foreach(Button but in btn)
        {
            but.gameObject.SetActive(true);
        }
    }

    public void Play()
    {
        NGHelper.instance.unlockMedal(71694);
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
