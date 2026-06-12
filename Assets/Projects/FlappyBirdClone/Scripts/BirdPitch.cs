using UnityEngine;
namespace FlappyBirdClone
{
[RequireComponent(typeof(Rigidbody2D))]
public class BirdPitch : MonoBehaviour
{
    public float maxAngle = 35f;
    public float minAngle = -90f;
    public float pitchMultiplier = 5f;
    public float rotationSpeed = 10f;
    
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (rb != null)
        {
            float targetAngle = rb.linearVelocity.y * pitchMultiplier;
            targetAngle = Mathf.Clamp(targetAngle, minAngle, maxAngle);
            
            Quaternion targetRotation = Quaternion.Euler(0, 0, targetAngle);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}

}