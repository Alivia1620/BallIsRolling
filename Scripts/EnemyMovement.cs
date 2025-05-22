using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public Transform player; // Reference to the player's transform
    private NavMeshAgent navMeshAgent; // Reference to the NavMeshAgent component

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navMeshAgent = GetComponent<navMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
