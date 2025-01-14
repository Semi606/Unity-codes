using UnityEngine;

public class code3 : MonoBehaviour
{
    private bool hasKey = false; 
    public Transform keyFollowPoint;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            hasKey = true;
            transform.position = keyFollowPoint.position; 
            transform.parent = keyFollowPoint; 
        }
    }

    public bool HasKey()
    {
        return hasKey;
    }
}
