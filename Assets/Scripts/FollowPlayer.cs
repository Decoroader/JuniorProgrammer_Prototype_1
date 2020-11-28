using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject playerViewer;
    private Vector3 offset = new Vector3(3.0f, 7.0f, -15.0f);
    void Update()
    {
        // offset the camera behind and right the player by adding to player's position
        transform.position = playerViewer.transform.position + offset;
    }
}
