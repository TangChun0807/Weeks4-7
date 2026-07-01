using UnityEngine.InputSystem;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tankPosition = transform.position;

        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            tankPosition.x -= speed * Time.deltaTime;

        }

        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {https://www.youtube.com/watch?v=nwvKwvE6Ug8
            tankPosition.x += speed * Time.deltaTime;
        }

        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {https://www.youtube.com/watch?v=nwvKwvE6Ug8
            tankPosition.y += speed * Time.deltaTime;
        }

        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            tankPosition.y -= speed * Time.deltaTime;
        }





        transform.position = tankPosition;
    }
}
