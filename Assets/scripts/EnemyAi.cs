using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    private NavMeshAgent ai;
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ai = GetComponent<NavMeshAgent>(); //Get the NavMeshAgent component attached to the enemy
    }

    // Update is called once per frame
    void Update()
    {
        ai.SetDestination(player.position); //Set the destination of the NavMeshAgent to the player's position

    }
}
