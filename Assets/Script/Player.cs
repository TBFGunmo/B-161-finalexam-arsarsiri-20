using UnityEngine;

public class Player : MonoBehaviour
{
    // public Fields
    [field: SerializeField]  private float moveSpeed = 5f; // speed movement
    [field: SerializeField]  private float jumpForce = 10f; // basic jump

    private Rigidbody2D rb;

    private bool isInvulnerable = false;

  

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();

    }

    public void SetMoveSpeed(float newSpeed) 
    {
        moveSpeed = moveSpeed * newSpeed;
        Debug.Log("Speed change to " + newSpeed);
    }

    public void SetInvulnerability(bool isEnabled) 
    {
        Debug.Log("Invulnerable statue " + isEnabled);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        PowerUpBase powerUpBaseItem = collision.GetComponent<PowerUpBase>();

        if (powerUpBaseItem != null) 
        {
            powerUpBaseItem.ApplyEffect(this);
        }

    }

    public void Move()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        // move left-right base on MoveSpeed
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }


}
