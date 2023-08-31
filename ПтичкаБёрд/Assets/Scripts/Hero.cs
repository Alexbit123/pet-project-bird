using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hero : MonoBehaviour
{

    public float force;
    private int score = 0;
    private bool flag = true;
    public Text scoreText;
    private new Rigidbody2D rigidbody;
    private Animator MyAnim;
    public GameObject Game;
    public GameObject Over;
    public GameObject BottomPlay;
    public GameObject BottomExit;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        MyAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if (flag)
        {
            Zamiranie();
        }
        scoreText.text = "Score: " + score;
        if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                MyAnim.SetBool("isJump", true);
                rigidbody.AddForce(Vector2.up * (force - rigidbody.velocity.y), ForceMode2D.Impulse);
                rigidbody.MoveRotation(rigidbody.velocity.y * 2.0F);
            }
            else
            {
                MyAnim.SetBool("isJump", false);
                rigidbody.MoveRotation(rigidbody.velocity.y * 1.0F);
            }
    }

    void Zamiranie()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Time.timeScale = 1.0F;
            flag = false;
        }
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        Game.SetActive(true);
        Over.SetActive(true);
        BottomPlay.SetActive(true);
        BottomExit.SetActive(true);
        Time.timeScale = 0.0F;
    }

    void OnTriggerExit2D(Collider2D other)

    {
        score++;
    }
}
