using UnityEngine;
using UnityEngine.InputSystem;

public class TrickShot : MonoBehaviour
{
    public float speed = 3f;

    public float timer = 0f;
    public float totalJumpTime = 1f;
    public bool timerIsRunning = false;

    public Vector3 startPosition;
    public AnimationCurve jumpCurve;
    public AnimationCurve rotationCurve;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            timerIsRunning = true;
            timer = 0f;
        }

        if (timerIsRunning)
        {
            timer += Time.deltaTime;

            Vector3 temp = transform.position;
            temp.y = startPosition.y + jumpCurve.Evaluate(timer / totalJumpTime);
            transform.position = temp;

            Vector3 currentRotation = transform.eulerAngles;
            currentRotation.z = rotationCurve.Evaluate(timer / totalJumpTime);
            transform.eulerAngles = currentRotation;


            if (timer >= totalJumpTime)
            {
                timerIsRunning = false;
                timer = 0f;
            }
        }
    }
}