using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    public int MaxHealth = 100;
    private int CurrentHealth;

    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    
    void Die(){
        Debug.Log(gameObject.name + " помер.");
        Destroy(gameObject);
    }

    public void TakeDamage(int damage){
        CurrentHealth -= damage;
        Debug.Log(gameObject.name + " отримав " + damage + " пошкоджень. Здороі'я: " + CurrentHealth);
        if (CurrentHealth <= 0){
            Die();
        }
    }
}
