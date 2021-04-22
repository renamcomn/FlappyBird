using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    public GameManager controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = FindObjectOfType<GameManager>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        controller.Score++;
        controller.ScoreText.text = controller.Score.ToString();
    }



}
