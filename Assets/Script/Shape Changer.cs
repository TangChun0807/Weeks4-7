using UnityEngine;

public class ShapeChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public Sprite[] sprites;

    public int currentIndex = 0;

    void Start()
    {
        spriteRenderer.sprite = sprites[currentIndex];
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            currentIndex++;

            if (currentIndex >= sprites.Length)
            {
                currentIndex = 0;
            }

            spriteRenderer.sprite = sprites[currentIndex];
        }
    }
}
