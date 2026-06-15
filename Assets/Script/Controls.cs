
using Unity.VisualScripting;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }


    public void colorChanger()
    {
        spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
        audioSource.Play();
    }

    public void angleRotation(float sliderValue)
    {

        

        Vector3 currentRotation = spriteRenderer.transform.eulerAngles;

        currentRotation.z = sliderValue;

        spriteRenderer.transform.eulerAngles = currentRotation;

        audioSource.Play();
    }
}
