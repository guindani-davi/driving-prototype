using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    private readonly float rotationSpeed = 1000f;

    void Update()
    {
        this.transform.Rotate(this.rotationSpeed * Time.deltaTime * Vector3.forward);
    }
}
