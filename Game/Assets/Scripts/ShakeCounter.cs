using UnityEngine;
using UnityEngine.Events;

public class ShakeCounter : MonoBehaviour
{
    public float shakeThreshold = 1.0f; // Adjust this value to control the shake sensitivity
    public int shakeCount = 0;
    public static UnityEvent onShake= new UnityEvent();


    private Vector3 lastAcceleration;

    void Update()
    {
        Vector3 acceleration = Input.acceleration;
        if (Vector3.Dot(acceleration, lastAcceleration) < 0.0f)
        {
            if (acceleration.sqrMagnitude >= shakeThreshold)
            {
                // A shake was detected
                shakeCount++;
                onShake.Invoke();
                // You can update the UI or perform other actions when a shake is detected
                Debug.Log("Shake count: " + shakeCount);
            }
        }

        lastAcceleration = acceleration;
    }
}
