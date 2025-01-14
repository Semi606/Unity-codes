using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public KeyPickup code3; 
    public string nextSceneName; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && code3.HasKey())
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
