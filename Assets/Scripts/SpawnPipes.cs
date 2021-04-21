using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{

    public GameObject pipe;
    public float heigth;
    public float maxTime;

    private float timer = 0;

    public static SpawnPipes instance;
    GameObject Logo;
    GameObject Tap;

    void Awake()
    {
        Logo = GameObject.Find("Logo");
        Tap = GameObject.Find("Tap");
    }

    void Start()
    {
        instance = this;
    }


    // Update is called once per frame
    public void Update()
    {

        if (GameManager.instance.comecou == true )
        {
            Logo.SetActive(false);
            Tap.SetActive(false);

            if (timer > maxTime)
            {
                GameObject newPipe = Instantiate(pipe);
                newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-heigth, heigth), 0);
                Destroy(newPipe, 10f);
                timer = 0;
            }

            timer += Time.deltaTime;
        }
        
        
    }
}
