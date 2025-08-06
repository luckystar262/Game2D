using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpFore;
    [SerializeField] Transform groundCheck;
    float rightLeft;
    private bool isGround;
    public LayerMask groundPlayer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGround = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundPlayer);
        rightLeft = Input.GetAxisRaw("Horizontal");
        if (rightLeft !=0) 
        {
            Move(rightLeft);
        }
        if (isGround && Input.GetKeyDown(KeyCode.Space)) 
        {
            JumpFore();
        }
        Debug.Log(isGround);
    }
    private void Move(float dir)
    {
        rb.velocity = new Vector2(dir * moveSpeed, rb.velocity.y);
    }

    private void JumpFore() 
    {
        rb.velocity = new Vector2( rb.velocity.x, jumpFore);
    }
}
