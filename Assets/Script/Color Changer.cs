
using UnityEngine;



public class ColorChanger : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;

    public float timer = 0f;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 1f)
        {


            spriteRenderer.color = Random.ColorHSV();


            timer = 0f;
        }

       
    }
}
