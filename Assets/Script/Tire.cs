using Unity.VisualScripting;
using UnityEngine;

public class Tire : MonoBehaviour
{
    //variable controls the speed of the tire
    public float tireRotateSpeed = -360f;
    //stores car gameobject
    public GameObject car;
    //stores te car move script
    private CarMove carScript;
    //this stores the curent car speed
    public float carSpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gets the rotation of the tire
        Vector3 currentRotation = transform.eulerAngles;
        //this get thhe car move componet from car
        carScript = car.GetComponent<CarMove>();
        //makes car speed the same as the current speed
        carSpeed = carScript.speed;
        //create the rotation based on the speed of the tire, when the speed is low the rotation is slower
        currentRotation.z += tireRotateSpeed * Time.deltaTime * carSpeed;
        //put new rotation on the tire to make it rotate
        transform.eulerAngles = currentRotation;

    }
}
