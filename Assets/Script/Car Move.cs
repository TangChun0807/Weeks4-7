using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    //controls the speed and the direction of the car
    public float speed = 1f;
    public GameObject slider;
    //add this variable to make the car change colors
    public SpriteRenderer carBody;
    //set a timer and keep track of the time
    private float timer = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //know the current car position
        Vector3 movement = transform.position;
        //change x position using the speed value , Time.deltaTime keep the movement smooth
        movement.x += speed * Time.deltaTime;
        //check if the car has reach the right side : 6 
        if (movement.x > 6f)
        {  //keep the car inside the range and not pass the right edge of the screen
            movement.x = 6f;
            //if the car is moving right reverse its direction by reversing its speed to -speed
            if (speed > 0)
            {
                speed = -speed;
            }
        }

        //check if the car has reach the left side : -6
        if (movement.x < -6f)
        {
            //keep the car inside and not pass the left side of the screen
            movement.x = -6f;
            //if th car is moving left, reverse the speed and make the direction starts moving right
            if (speed < 0)
            {
                speed = -speed;
            }
        }

        //add the updated position to the car
        transform.position = movement;
        //add the time between frames and the timer
        timer += Time.deltaTime;
        //checks if five seconds has passed
        if (timer >= 5f)
        {
            //reset the timer
            timer = 0;
            //changes the color of the cr into random colors
            carBody.color = new Color(Random.value,Random.value,Random.value);
        }
    }

    //create changing value of the slider to change the size of the car
    public void changeScale(float sliderValue)
    {
        transform.localScale = new Vector3(sliderValue, sliderValue, 1);
    }

    //create a slider that can change the car speed when the value of the slider is changed
    public void ChangeSpeed(float newSpeed)
    {
        speed = newSpeed;
    }


}
