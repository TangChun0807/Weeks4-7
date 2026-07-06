using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float speed = 1f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = transform.position;
        movement.x += speed * Time.deltaTime;

        if (movement.x > 6f || movement.x < -6f )
        {
            speed = -speed;
        }

        transform.position = movement;
    }
}
