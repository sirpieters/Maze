using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject enemyPrefab;
    private GameObject enemy;

    private GameObject[] enemyCounter;
    public int maxEnemyCount=20;

    public Transform[] spanlist;

    void Update()


    {

        enemyCounter = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemyCounter.Length <maxEnemyCount ) // if there is no enemy in the scene
        {
            enemy = Instantiate(enemyPrefab) as GameObject;
            enemy.transform.position = spanlist[Random.Range(0, spanlist.Length)].position;
            // enemy.transform.localPosition = new Vector3(0, 1, 0);
            print(enemy.transform.position.x);

            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle, 0); // sets the direcion the enemy faces
        }
    }

}
