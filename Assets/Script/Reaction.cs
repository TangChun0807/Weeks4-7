
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Reaction : MonoBehaviour
{

    Image m_Image;

    public Sprite nearSpirte;
    public Sprite farSpirte;
    



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject NPC = GameObject.Find("NPC");
        GameObject Player = GameObject.Find("Player");
        GameObject Image = GameObject.Find("Image");
        
        



        float distance = Vector3.Distance(NPC.transform.position, Player.transform.position);

        



        if (distance < 2)
        {
            m_Image.sprite = nearSpirte;

        }
        else
        {
            m_Image.sprite = farSpirte;

        }



    }
}
