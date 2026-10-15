using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    private float deltaTime;
    private void Update()
    {
        UpdateDeltaTime(Time.deltaTime);
        Move();
    }

    private void UpdateDeltaTime(float deltaTime)
    {
        this.deltaTime =deltaTime;
    }

    //private void FixedUpdate()
    //{
    //    UpdateDeltaTime(Time.fixedDeltaTime);
    //    Move();
    //}

    private void Move()
    {
        var oldPosition = transform.position;
        var deltaY = deltaTime * speed;
        var movement = new Vector3(0, deltaY, 0);
        var newPosition = oldPosition + movement;
        transform.position = newPosition;
    }
}
