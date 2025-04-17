using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5f;
    public float jump = 4f;
    Vector2 InputVec2;
    private bool jumpCheck;
    private Animator animator;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(InputVec2.x * speed, rb.linearVelocity.y);
        LeftandRight();
        animator.SetFloat("run", Mathf.Abs(InputVec2.x));//변화하는 x좌표의 절대값을 인스펙터에서 비교
    }

    void OnMove(InputValue value){
        InputVec2 = value.Get<Vector2>();
    }
    
    void OnJump(){
        if(jumpCheck){
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jump);
            animator.SetBool("jump",true);
        }
        
    }

    void LeftandRight(){
        if (InputVec2.x > 0){
            rb.transform.localScale = new Vector3(1,1);
        }
        else if(InputVec2.x < 0){
            rb.transform.localScale = new Vector3(-1,1);
        }
    }
    //중복 점프 방지
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) // 지면에 닿았을 때
        {
            jumpCheck = true; // 지면에 닿았다고 설정
            animator.SetBool("jump", false);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) // 지면에 닿았을 때
        {
            jumpCheck = false; // 지면과 멀어졌을떄떄
        }
    }

    // void jumpAnim(){
    //     if()
    //     animator.SetBool("jump",true);
    // }
}
