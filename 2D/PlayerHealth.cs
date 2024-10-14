using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Додайте код для смерті гравця (наприклад, перезапуск рівня або анімація смерті)
        Debug.Log("Player died!");
    }
}
