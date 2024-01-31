using UnityEngine;

public class JumpController : MonoBehaviour
{
    public float jumpForce = 7f;
    public Rigidbody2D m_Rigidbody;
    public Transform groundCheck; 
    public float groundCheckRadius = 0.4f; 
    public LayerMask collisionLayers; 
    private bool isJumping = false;
    private bool isGrounded = false;

    void Start()
    {

    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, collisionLayers);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
        }
    }

  private void FixedUpdate()
    {
        if (isJumping)
        {
            isJumping = false;

            m_Rigidbody.velocity = new Vector2(m_Rigidbody.velocity.x, 0);
            m_Rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}
