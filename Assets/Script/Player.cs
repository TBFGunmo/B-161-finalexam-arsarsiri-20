using UnityEngine;

public class Player : MonoBehaviour
{
    // public Fields
    [field: SerializeField] private float moveSpeed { get; set; } // Encapsulation get set


    [field: SerializeField]  private float jumpForce { get; set; } // Encapsulation get set


    private Rigidbody2D rb;

    [field: SerializeField]  private bool isInvulnerable { get; set; } // Encapsulation get set


    public void initPlayer(float newMoveSpeed, float newJumpForce, bool startInvulnerable) 
    {
        moveSpeed = newMoveSpeed;
        jumpForce = newJumpForce;
        isInvulnerable = startInvulnerable;
    }

    void Start()
    {
        initPlayer(5f, 10f, false);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();

    }

    public void SetMoveSpeed(float speedIncrease) 
    {
        moveSpeed = moveSpeed * speedIncrease;
        Debug.Log("Speed change to " + moveSpeed);
    }

    public void SetInvulnerability(bool isEnabled) 
    {
        isInvulnerable = isEnabled;
        Debug.Log("Invulnerable statue : " + isEnabled);
    }

    public void GetHeavyItem(float jumpDecrease)
    {
        jumpForce = jumpDecrease;
        Debug.Log("You get a heavy item | your new jump : " + jumpDecrease);
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
