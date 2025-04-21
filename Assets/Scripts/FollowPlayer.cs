using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private KeyCode toggleCameraKey;
    private Vector3 topViewOffset = new Vector3(0, 5, -7);
    private Vector3 frontViewOffset = new Vector3(0, 4, 1);
    private Vector3 offset;

    void Start()
    {
        this.offset = topViewOffset;
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(toggleCameraKey))
        {
            if (this.offset == this.topViewOffset)
            {
                this.offset = this.frontViewOffset;
            }
            else
            {
                this.offset = this.topViewOffset;
            }
        }

        transform.position = this.player.transform.position + offset;
    }
}
