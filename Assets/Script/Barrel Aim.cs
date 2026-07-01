using UnityEngine;
using UnityEngine.InputSystem;

public class BarrelAim : MonoBehaviour
{
    public Camera gameCamera;
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

        Vector3 direction = worldMousePosition - mousePosition;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z = angle;
        transform.eulerAngles = currentRotation;
    }
}
