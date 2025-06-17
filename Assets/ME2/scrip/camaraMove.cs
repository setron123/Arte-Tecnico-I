using UnityEngine;

public class camaraMove : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 30f;
    public Vector3 axis = Vector3.up;

    void Update()
    {
        if (target == null) return;

        transform.RotateAround(target.position, axis, rotationSpeed * Time.deltaTime);
        transform.LookAt(target);
    }
}
