using UnityEngine;

public class Hider : MonoBehaviour
{
    public Vector3 hidePosition;


    public void Hide()
    {
        transform.position = hidePosition;
        Debug.Log(hidePosition);
    }
}
