using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class Training : MonoBehaviour
{
    public SpriteRenderer piplup;
    public Camera gameCamera;
    public Color catchColor;
    public Hider creatureHider;

    


    public List<SpriteRenderer> uncaughtCreatures;
    public List<SpriteRenderer> caughtCreatures;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isClicked = Mouse.current.leftButton.wasPressedThisFrame;
        Vector3 mousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(mousePosition);
        worldMousePosition.z = 0f;

        if (isClicked)
        {
            //caughtCreatures
            //for each element I want to ouput that to the console
            for (int i = 0; i < uncaughtCreatures.Count; i++)
            {
                Debug.Log(caughtCreatures[i]);

            }

            if(caughtCreatures.Count > 0)
            {
                Debug.Log(caughtCreatures[0]);

            }
            
        }
        

        if (isClicked && piplup.bounds.Contains(worldMousePosition))
        {
            piplup.color = catchColor;

            bool isCreatureCaught = caughtCreatures.Contains(piplup);
            //Debug.Log("Is creature caught[" + isCreatureCaught.ToString() + "]");

            if (!isCreatureCaught)
            {
               // creatureHider.Hide();
                caughtCreatures.Add(piplup);
                
                

            }
            

            uncaughtCreatures.Remove(piplup);
            

            
        }

    }
}
