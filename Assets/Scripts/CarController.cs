using UnityEngine;

public class CarController : MonoBehaviour
{
    private readonly float speed = 5f;

    void Update()
    {
        this.transform.Translate(this.speed * Time.deltaTime * Vector3.forward);
    }
}
