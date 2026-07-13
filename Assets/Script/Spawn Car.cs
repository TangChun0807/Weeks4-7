using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class SpawnCar : MonoBehaviour
{
    //Stores the car prefab that will be spawned 
    public GameObject carPrefab;
    
    //Stores all the spawned cars to the list 
    public List<GameObject> cars = new List<GameObject>();

    // Display the number of cars on the screen 
    public TMP_Text carCountText;

    void Start()
    {
        //Runs one time during the game start and sets the text to show cars count srtart from zero
        carCountText.text = "Cars: 0";
    }

    //Create my own method for spawning the new car 
    public void carSpawn()
    {
        //creates a random position for the car spwaning 
        Vector3 spawnPosition = new Vector3( Random.Range(-5f, 5f), 0f, 0f);

        //instantiate a new car prefab. Also the car prefab will spawn a random position
        GameObject spawnedObject = Instantiate(carPrefab,spawnPosition, Quaternion.identity);

        //Add the newest car to the list 
        cars.Add(spawnedObject);

        //Use the updateCarCount method to update the car count text on UI 
        updateCarCount();
    }


    //Create the delete car method 
    public void deleteCar()
    {
        if (cars.Count > 0)
        {
            //delete the latest car that has spawned
            Destroy(cars[cars.Count - 1]);
            //remove the car from the list
            cars.RemoveAt(cars.Count - 1);
            //updates the car count
            updateCarCount();
        }
    }

    //create change the car size method
    //using the value from the silder 
    public void changeAllSize(float sliderValue)
    {
        for (int i = 0; i < cars.Count; i++)
        {
            if (cars[i] != null)
            {
                cars[i].transform.localScale = new Vector3(sliderValue, sliderValue, 1f);
            }
        }
    }

    //create change all the speed for cars prefab method 
    //using the value of the silder
    public void changeAllSpeed(float sliderValue)
    {
        for (int i = 0; i < cars.Count; i++)
        {
            if (cars[i] != null)
            {
                CarMove carMove =
                    cars[i].GetComponent<CarMove>();

                if (carMove != null)
                {
                    carMove.speed = sliderValue;
                }
            }
        }
    }


    void updateCarCount()
    {   
        //make the text in UI to change to the number of cars showned on screen
        carCountText.text = "Cars: " + cars.Count;
    }
}

