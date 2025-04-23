using UnityEngine;

public class OtherFeatures : MonoBehaviour
{
    public float bedrockSpeed = 5f;
    private bool isClimbing = false;
    private Rigidbody2D rb;
    private Animator animator;
    private float originalGravity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        originalGravity = rb.gravityScale;
    }

    void Update()
    {
        if (isClimbing)
        {
            float verticalInput = Input.GetAxis("Vertical");
            // 움직임 있을 때만 Climb_Loop 진입
            if (Mathf.Abs(verticalInput) > 0.01f)
            {
                animator.SetBool("isClimbingMoving", true);
            }
            else
            {
                animator.SetBool("isClimbingMoving", false);
            }

            HandleClimbing(verticalInput);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Climbable"))
        {
            isClimbing = true;
            animator.SetBool("climb", true);
            rb.gravityScale = 0f;
            rb.linearVelocity = Vector2.zero;
            Debug.Log("Start Climbing");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Climbable"))
        {
            isClimbing = false;
            animator.SetBool("climb", false);
            animator.SetBool("isClimbingMoving", false);
            rb.gravityScale = originalGravity;
        }
    }

    private void HandleClimbing(float verticalInput)
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, verticalInput * bedrockSpeed);
    }
}
