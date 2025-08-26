using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        if (horizontalInput != 0f)
        {
            Move(horizontalInput);
        }
        
    }
    private void Move(float dir)
        {
            rb.velocity = new Vector2(dir * moveSpeed, rb.velocity.y);
        }
}
