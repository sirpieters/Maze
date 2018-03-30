using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public int EnemySpeed;
    public Transform goal;


    GameObject m_player; // This is to find the m_player

    private void Awake()
    {
        m_player = GameObject.Find("Player");
    }

       
   void FixedUpdate () {
      NavMeshAgent agent = GetComponent<NavMeshAgent>();
    agent.destination = m_player.transform.position; 
   }


	private void Update()
	{
        print(transform.position.x);
	}
}

    /* void Update()
    {
        Vector3 localPosition = m_player.transform.position - transform.position;
        localPosition = localPosition.normalized;
        transform.Translate(localPosition.x * Time.deltaTime * EnemySpeed,
                            0f,
                            localPosition.z * Time.deltaTime * EnemySpeed); // What this code is doing is that it is searching for the local position of the m_player and moves to that.
    } */
