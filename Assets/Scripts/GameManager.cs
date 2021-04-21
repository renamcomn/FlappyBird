using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool comecou;
    public bool gameOver;

    public static GameManager instance;

    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            if(!comecou)
            {
                comecou = true;
                SpawnPipes.instance.Update();
            }
            
        }
        
    }
}
