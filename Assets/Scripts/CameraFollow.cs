using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform; //what to follow
    public Vector3 offset;

    public float smoothSpeed = 0.125f;

    private void LateUpdate() {
        if(playerTransform != null)
            transform.position = playerTransform.position + offset;
    }
}
