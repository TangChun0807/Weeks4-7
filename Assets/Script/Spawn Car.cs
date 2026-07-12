using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{
    public GameObject carPrefab;
    public List<GameObject> cars = new List<GameObject>();

    public TMP_Text carCountText;

    void Start()
    {
        carCountText.text = "Cars: 0";
    }

    public void carSpawn()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(-5f, 5f),
            0f,
            0f
        );

        GameObject spawnedObject = Instantiate(
            carPrefab,
            spawnPosition,
            Quaternion.identity
        );

        cars.Add(spawnedObject);

        updateCarCount();
    }

    public void deleteCar()
    {
        if (cars.Count > 0)
        {
            Destroy(cars[cars.Count - 1]);

            cars.RemoveAt(cars.Count - 1);

            updateCarCount();
        }
    }

    public void changeAllSize(float sliderValue)
    {
        for (int i = 0; i < cars.Count; i++)
        {
            if (cars[i] != null)
            {
                cars[i].transform.localScale =
                    new Vector3(sliderValue, sliderValue, 1f);
            }
        }
    }

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
        carCountText.text = "Cars: " + cars.Count;
    }
}

