using UnityEngine;

public class Player : MonoBehaviour
{
    // public Fields
    private float moveSpeed = 5f; // speed movement
    private float jumpForce = 10f; // basic jump

    [field:SerializeField] private Rigidbody2D rb;

    private bool isInvulnerable = false;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 1. movement (left-right using A/D/arrow keys)
        float moveInput = Input.GetAxisRaw("Horizontal");
        // move left-right base on MoveSpeed
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        // 2. Jump (No gound Check Requied)
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

    }

    public void SetMoveSpeed(float newMoveSpeed) 
    {
    
    }

    public void SetInvulnerability(bool set) 
    {
    
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    public void Move()
    {

    }

    public void Jump()
    {

    }


}
