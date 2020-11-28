using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject playerViewer;
    void Update()
    {
        transform.position = playerViewer.transform.position;
    }
}
