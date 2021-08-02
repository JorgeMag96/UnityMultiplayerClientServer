using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; //what to follow
    public Vector3 offset;

    public float smoothSpeed = 0.125f;

    void LateUpdate() {
        if (target != null)
        {
            transform.position = target.position + offset;
        }
    }
}
