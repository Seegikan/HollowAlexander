using UnityEngine;

public class AddTorque : MonoBehaviour
{
    public Vector3 axisRotate = Vector3.zero;
    public float speedRotate = 15f;
    public Rigidbody2D rigidbody2DTorque;

    private void FixedUpdate()
    {
        rigidbody2DTorque.MoveRotation(speedRotate );
    }
}
