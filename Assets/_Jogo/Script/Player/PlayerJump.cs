using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool canJump = true;

    bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundLayer;

    [SerializeField]
    float JumpForce;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        
        if (isGrounded)
        {
            FindObjectOfType<AudioManager>().Play("Land");
            Jump();
        }
     
    }

    // Update is called once per frame

    void Update()
    {

    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    public void Jump()
    {
        if (canJump == true)
        {
            rb.velocity = new Vector2(0, JumpForce);
            FindObjectOfType<AudioManager>().Play("Jump");
        }
        
    }

  
}
