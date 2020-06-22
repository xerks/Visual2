using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotSpeed = 30f;

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed;

        Camera camera = Camera.main;

        Vector3 right = Vector3.Cross(camera.transform.up, transform.position - camera.transform.position);
        Vector3 up = Vector3.Cross(transform.position - camera.transform.position, right);

        transform.rotation = Quaternion.AngleAxis(-rotX, up) * transform.rotation;
        transform.rotation = Quaternion.AngleAxis(rotY, right) * transform.rotation;
    }
}
