using UnityEngine;

public class Changer : MonoBehaviour
{
    public SpriteRenderer changeRenderer;
    public Sprite changeSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        changeRenderer.sprite = changeSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
