using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlScript: MonoBehaviour
{
    public GameObject timeIsUp, restartButton, youWin;



    void Update()
    {
        if (Timer.time<=0)
        {
            Time.timeScale = 0;
            timeIsUp.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            //gameover state

        }
    }
    public void restartScene()
    {
        timeIsUp.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        youWin.gameObject.SetActive(false);
        Time.timeScale = 1;
        Timer.time = 30f;
        SceneManager.LoadScene("Roll a Ball");
        //restarting the scene
    }
}
