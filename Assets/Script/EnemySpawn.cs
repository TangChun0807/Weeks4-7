
using UnityEngine;
using System.Collections.Generic;
using TMPro;


public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public List<GameObject> enemies = new List<GameObject>();
    public TMP_Text victoryText;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        victoryText.text = "";
        for (int i = 0; i < 5; i++)
        {

            Vector3 randomPosition = new Vector3(Random.Range(-6, 6f), Random.Range(-3, 3), 0f);
            enemies.Add(Instantiate(enemyPrefab, randomPosition, Quaternion.identity));

        }


    }

    // Update is called once per frame
    void Update()
    {
        enemies.RemoveAll(enemy => enemy == null);

        if (enemies.Count == 0)
        {
            victoryText.text = "Victory!";
        }
    }
}
