using UnityEngine;

public class Bonus : MonoBehaviour
{
    public float speedBoost = 2f;
    public float duration = 5f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ApplySpeedBoost(other));
        }
    }

    IEnumerator ApplySpeedBoost(Collider2D player)
    {
        PlayerMovement movement = player.GetComponent<PlayerMovement>();
        if (movement != null)
        {
            movement.speed += speedBoost;
            Destroy(gameObject); 
            yield return new WaitForSeconds(duration);
            movement.speed -= speedBoost;
        }
    }
}
