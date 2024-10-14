using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }

    void Jump()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}


/*
Додайте Rigidbody2D: У вашого гравця повинен бути компонент Rigidbody2D.
Додайте Collider: Додайте 2D-колайдер, наприклад, BoxCollider2D.
Ground Check: Створіть пустий об'єкт (GameObject) як дочірній елемент вашого гравця, помістіть його біля ніг (де буде перевірятися, чи гравець на землі) і призначте його у поле groundCheck в інспекторі.
Ground Layer: Створіть шар для землі, який ви будете використовувати для перевірки зіткнення. У полі groundLayer призначте цей шар.
*/
