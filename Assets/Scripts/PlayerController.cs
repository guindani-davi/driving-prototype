using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private readonly float speed = 10f;
    private readonly float turnSpeed = 50f;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        // Get the input from the player
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        transform.Translate(forwardInput * this.speed * Time.deltaTime * Vector3.forward);
        // Rotate the vehicle
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }
}
