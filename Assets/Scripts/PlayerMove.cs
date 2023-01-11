using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 moveVector;
    public float speed = 2f;
    public bool faceRight = true;
    public Animator anim;
    public float jumpforce = 7f;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        walk();

        jump();
        Reflect();

    }

    void walk()
    {

        moveVector.x = Input.GetAxis("Horizontal");
        
            rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
            anim.SetFloat("2", Mathf.Abs(moveVector.x));

        



    }

    void Reflect()
    {
        if ((moveVector.x > 0 && !faceRight) || (moveVector.x < 0 && faceRight))
        {
            transform.localScale *= new Vector2(-1, 1);
            faceRight = !faceRight;
        }
    }

    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }
    }
  }
