using UnityEngine;
using UniRx;
using System;

public class FighterController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    [SerializeField] int playerID;
    [SerializeField] float speed;
    [SerializeField] float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        InputProvider.OnMoveKey
            .Where(x => x.Item1 == playerID)
            .Subscribe(x =>
            {
                Move(x.Item2);
            })
            .AddTo(this);

        InputProvider.OnJumpKeyDown
            .Where(x => x.Item1 == playerID)
            .Subscribe(_ =>
            {
                Jump();
            })
            .AddTo(this);

        InputProvider.OnAttackKeyDown
            .Where(x => x.Item1 == playerID)
            .Subscribe(_ =>
            {
                Attack();
            })
            .AddTo(this);
    }

    void Move(float moveInputValue)
    {
        // TODO 移動(KBも含めて)すべての移動を管理
        if (moveInputValue < 0)
        {
            rb.linearVelocity = new Vector2(-speed, rb.linearVelocity.y);
        }
        else if (moveInputValue > 0)
        {
            rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
        }
        else
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
        }
    }

    void Jump()
    {
        // TODO ジャンプ処理
        Debug.Log($"Player {playerID} Jump");
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    [SerializeField] SkillScriptableObject[] skills;
    [SerializeField] 

    void Attack()
    {
        // TODO 攻撃処理
        Debug.Log($"Player {playerID} Attack");
        skills[0].ExecuteSkill(this);
    }

    void Block()
    {
        // TODO ブロック処理
        Debug.Log($"Player {playerID} Block");
    }
}