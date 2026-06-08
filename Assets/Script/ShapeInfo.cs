using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class ShapeInfo : MonoBehaviour
{
    public SpriteRenderer shapeRenderer;
    public Camera gameCamera;
    public TMP_Text descriptionText;
    public string description;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Mouse.current.position.ReadValue();

        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(mousePosition);
        worldMousePosition.z = 0f;

        if (shapeRenderer.bounds.Contains(worldMousePosition))
        {
            descriptionText.text = description;
        }
    }
}
