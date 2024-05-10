using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class movement : MonoBehaviour
{
    public Transform goal; // Reference to the goal object

    private NavMeshAgent agent; // Reference to the NavMeshAgent component

    // Start is called before the first frame update
    void Start()

    {
        agent = GetComponent<NavMeshAgent>(); // Get the NavMeshAgent component

        if (goal != null)
        {
            agent.SetDestination(goal.position); // Set the destination to the goal position
        }
    }

    // Update is called once per frame
    void Update()
    {
        // You can add any additional logic here if needed
    }
}
