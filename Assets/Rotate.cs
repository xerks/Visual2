using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotSpeed = 30f;
    public bool rotatX = true;

    void OnMouseDrag()
    {
        float rotX = -Input.GetAxis("Mouse X") * rotSpeed;
        float rotY = -Input.GetAxis("Mouse Y") * rotSpeed;

        //Camera camera = Camera.main;

        //Vector3 right = Vector3.Cross(camera.transform.up, transform.position - camera.transform.position);
        //Vector3 up = Vector3.Cross(transform.position - camera.transform.position, right);


        //transform.rotation = Quaternion.AngleAxis(-rotX, up) * transform.rotation;
        transform.rotation *= Quaternion.AngleAxis(rotX, Vector3.up);
        if (rotatX)
        {
            //    transform.rotation = Quaternion.AngleAxis(rotY, right) * transform.rotation;
            transform.rotation *= Quaternion.AngleAxis(rotY, Vector3.right);
        }
    }
}
