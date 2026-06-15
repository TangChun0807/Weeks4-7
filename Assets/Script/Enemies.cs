using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Enemies : MonoBehaviour
{

    public TMP_Text healthText;
    public int healthValue = 3;
    public SpriteRenderer enemyRenderer;

    void Start()
    {
        healthText.text = healthValue.ToString();
    }

    void Update()
    {
        Vector3 mousePosition = Mouse.current.position.ReadValue();
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        worldPosition.z = 0f;

        bool isMouseClicked = Mouse.current.leftButton.wasPressedThisFrame;
        bool mouseOnEnemy = enemyRenderer.bounds.Contains(worldPosition);

        if (isMouseClicked && mouseOnEnemy)
        {
            healthValue--;
            healthText.text = healthValue.ToString();

            if (healthValue <= 0)
            {
                Destroy(gameObject);
            }
        }
    }









}











