using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(25.0f, 1.0f, 0);
    private Vector3 rotateToPlane = new Vector3(0, 90.0f, 0);

	private void Start()
	{
        transform.Rotate(rotateToPlane);
    }

    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
