using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float speed = 1f;
    public GameObject slider;



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

    public void changeScale(float sliderValue)
    {
        transform.localScale = new Vector3(sliderValue, sliderValue, 1);
    }


    public void ChangeSpeed(float newSpeed)
    {
        speed = newSpeed;
    }


}
