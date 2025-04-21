using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    [SerializeField] private GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 10);

    void Start()
    {
        transform.rotation = Quaternion.Euler(0, -90, 0);
    }

    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
