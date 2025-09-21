using UnityEngine;

public class AddTorque : MonoBehaviour
{
    public Vector3 axisRotate = Vector3.zero;
    public float speedRotate = 15f;
    public Rigidbody2D rigidbody2D;

    private void FixedUpdate()
    {
        rigidbody2D.MoveRotation(speedRotate );
    }
}
