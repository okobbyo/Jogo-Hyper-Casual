using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Player;
    [SerializeField] private float JumpForce;

    private float moveInput;
    [SerializeField] private float Speed;

    private int currentScore;
    [SerializeField] private Text scoreText;


    void Start()
    {
        Application.targetFrameRate = 60;
        Player = GetComponent<Rigidbody2D>();    
    }
    void Update()
    {
        Vector3 dir = Vector3.zero;
        //moveInput = Input.GetAxis("Horizontal");
        //
        //dir.y = -Input.acceleration.y;
        dir.x = Input.acceleration.x;
        if (dir.sqrMagnitude > 1)
            dir.Normalize();
        dir *= Time.deltaTime;
        transform.Translate(dir * Speed);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            Player.velocity = new Vector2(Player.velocity.x, JumpForce);
           
        }
    }
    public void Right()
    {
        Player.velocity = new Vector2(1 * Speed, Player.velocity.y);
        return;
    }
    public void Left()
    {
        Player.velocity = new Vector2(-1 * Speed, Player.velocity.y);
        return;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        { 
            Time.timeScale = 0.9f; 
        }

        if (collision.gameObject.tag == "Score")
        {
            GainScore();
        }
    }

    void GainScore()
    {
        currentScore++;
        scoreText.text = "Score: " + currentScore;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Time.timeScale = 1f;
    }
}
