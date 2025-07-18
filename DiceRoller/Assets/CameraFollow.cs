using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Assign your dice here
    public Vector3 offset = new Vector3(0, 6, -10);

    void LateUpdate()
    {
        transform.position = target.position + offset;
        transform.LookAt(target); // Optional: make camera look at dice
    }
}
