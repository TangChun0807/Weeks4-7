using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    public GameObject runnerPrefab;
    public Vector3 spawnPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //spawn a runner
           // Instantiate(runnerPrefab);

            //spawn a child of the runner 
            
          //  Instantiate(runnerPrefab, transform);

         


            //Spawn a runner at a Specific position
            Instantiate(runnerPrefab, spawnPosition, Quaternion.identity);



            ////Position of zero
            //Vector3 zeroVector = Vector3.zero;

            ////Rotation of zero
            //Quaternion zeroRotation = Quaternion.identity;
        }
    }
}
