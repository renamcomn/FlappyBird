using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 1;
    private Rigidbody2D rb;

    public GameObject gameOver;
    AudioSource[] sounds;
    public AudioSource touchSound;
    public AudioSource collisionSound;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sounds = GetComponents<AudioSource>();
        touchSound = sounds[0];
        collisionSound = sounds[1];

    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.comecou == true)
        {
            rb.isKinematic = false;
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.up * speed;
                touchSound.Play();
            }
            transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * 3);
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collisionSound.Play();
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }


}
