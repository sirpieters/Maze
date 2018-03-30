using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    private GameObject enemy;

    private GameObject[] enemyCounter;
    public int maxEnemyCount = 4;

    public Transform[] spanlist;

    void Update()


    {

        enemyCounter = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemyCounter.Length < maxEnemyCount) // if there is no enemy in the scene
        {
            enemy = Instantiate(enemyPrefab) as GameObject;
            enemy.transform.position = new Vector3(Random.Range(-25.0f, 25.0f), 1, Random.Range(-25.0f, 25.0f));
            // enemy.transform.localPosition = new Vector3(0, 1, 0);
            print(enemy.transform.position.x);

            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle, 0); // sets the direcion the enemy faces
        }
    }

}


 