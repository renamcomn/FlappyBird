using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 1;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

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
            }
            transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * 3);
        }
       
    }
}
