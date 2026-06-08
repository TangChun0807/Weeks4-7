using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = transform.position;

        if (Keyboard.current.upArrowKey.isPressed)
        {
            playerPosition.y += speed * Time.deltaTime;
        }

        if (Keyboard.current.downArrowKey.isPressed)
        {
            playerPosition.y -= speed * Time.deltaTime;
        }

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            playerPosition.x -= speed * Time.deltaTime;
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            playerPosition.x += speed * Time.deltaTime;
        }

        transform.position = playerPosition;
    }
}