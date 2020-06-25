using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotSpeed = 30f;
    public bool rotatX = true;
    public bool rotatY = true;

    void OnMouseDrag()
    {
        float rotX = -Input.GetAxis("Mouse X") * rotSpeed;
        float rotY = -Input.GetAxis("Mouse Y") * rotSpeed;

        if (rotatY)
        {
            transform.rotation *= Quaternion.AngleAxis(rotX, Vector3.up);
        }
        if (rotatX)
        {
            transform.rotation *= Quaternion.AngleAxis(rotY, Vector3.right);
        }
    }
}
