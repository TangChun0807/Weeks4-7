using UnityEngine;
using System.Collections.Generic;
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


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < reactionDistance)
        {
            bubble.position = player.position + new Vector3(0, 1, 0);

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
