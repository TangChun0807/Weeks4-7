using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Reaction : MonoBehaviour
{
    public Transform player;
    public Transform bubble;
    public Image reactionImage;
    public List<Sprite> reactionSprites;
    public float reactionDistance;
    public Vector3 hidePosition;
    bool isShowing = false;
    public GameObject eryx;

    private Transform testTransform;


    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        testTransform = eryx.GetComponent<Transform>();
        float distance = Vector3.Distance(transform.position, testTransform.position);
        
        


        if (distance < reactionDistance)
        {
            bubble.position = testTransform.position + new Vector3(0, 1, 0);

            if (isShowing == false)
            {
                int randomIndex = Random.Range(0, reactionSprites.Count);
                reactionImage.sprite = reactionSprites[randomIndex];

                isShowing = true;
            }
        }
        else
        {
            bubble.position = hidePosition;
            isShowing = false;
        }
    }
}
