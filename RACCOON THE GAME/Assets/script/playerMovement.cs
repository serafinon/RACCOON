using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public float speed = 10;
    
    private bool isGrounded = false;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        rb.AddForce(movement * speed);
        if (Input.GetButtonDown("Jump") && isGrounded==true)
        {
            Debug.Log("salta diocane");
            rb.AddForce(jump * jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}