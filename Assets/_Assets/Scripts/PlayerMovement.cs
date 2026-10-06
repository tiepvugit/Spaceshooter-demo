using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 worldPoint;
    [SerializeField] private Camera camera;
    private void Update()
    {
        Debug.Log($"Mouse Position: {Input.mousePosition}");
        //camera = Camera.main;
         worldPoint = camera.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 0;
        transform.position = worldPoint;

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(worldPoint,  0.1f);
    }
}