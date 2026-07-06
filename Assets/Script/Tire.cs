using Unity.VisualScripting;
using UnityEngine;

public class Tire : MonoBehaviour
{
    public float tireRotateSpeed = -360f;
    public GameObject car;
    private CarMove carScript;
    public float carSpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 currentRotation = transform.eulerAngles;
        carScript = car.GetComponent<CarMove>();
        carSpeed = carScript.speed;
        currentRotation.z += tireRotateSpeed * Time.deltaTime * carSpeed;
        transform.eulerAngles = currentRotation;
        



    }
}
