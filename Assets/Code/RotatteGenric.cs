using UnityEngine;

public class RotatteGenric : MonoBehaviour
{
    public Vector3 axisRotate = Vector3.zero;
    public float speedRoatate = 15f;

    void Update()
    {
        gameObject.transform.Rotate(axisRotate * speedRoatate * Time.deltaTime) ;
    }
}
