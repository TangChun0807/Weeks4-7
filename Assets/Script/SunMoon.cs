using UnityEngine;

public class SunMoon : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = currentRotation;
    }
}
