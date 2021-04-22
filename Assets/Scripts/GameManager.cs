using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public bool comecou;
    public bool gameOver;

    public int Score;
    public Text ScoreText;

    public static GameManager instance;

    void Start()
    {
        instance = this;
        ScoreText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            if(!comecou)
            {
                comecou = true;
                ScoreText.enabled = true;
                SpawnPipes.instance.Update();
            }
            
        }
        
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
