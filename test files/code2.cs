using UnityEngine;

public class code2 : MonoBehaviour
{
    public Transform player; 
    public float smoothSpeed = 0.125f;
    public Vector3 offset; 

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
    }
}
