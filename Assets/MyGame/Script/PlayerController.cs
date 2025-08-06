using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpFore = 5f;
    [SerializeField] Transform groundCheck;
    public LayerMask groundLayer;
    private bool isGround;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        isGround = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
        //Debug.Log(isGround);
        if (horizontalInput != 0f)
        {
            Move(horizontalInput);
        }
        if (isGround && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    private void Move(float dir)
    {
        rb.velocity = new Vector2(dir * moveSpeed, rb.velocity.y);
    }
    private void Jump() 
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpFore);
    } 
}
