using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    Animator animator;
    int comboCount = 0;
    float lastClickTime = 0f;
    public float comboResetTime = 1f; // 1초 안에 안 누르면 초기화

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  // 마우스 왼쪽 버튼 클릭 시
        {
            float timeSinceLastClick = Time.time - lastClickTime;

            // 콤보 초기화 시간이 지났으면 초기화
            if (timeSinceLastClick > comboResetTime)
            {
                comboCount = 0;
            }

            comboCount = Mathf.Clamp(comboCount + 1, 1, 3); // 1~3 사이 유지
            lastClickTime = Time.time;

            animator.SetInteger("ComboCount", comboCount);
            animator.SetTrigger("Attack");  // 공격 애니메이션 트리거
        }

        // 일정 시간 지나면 콤보 초기화
        if (Time.time - lastClickTime > comboResetTime)
        {
            comboCount = 0;
            animator.SetInteger("ComboCount", 0);
        }
    }
}
