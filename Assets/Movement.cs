using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movement : MonoBehaviour
{
    private NavMeshAgent agent; // Reference to the NavMeshAgent component

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); // Get the NavMeshAgent component
/*
        if (goal != null)
        {
            agent.SetDestination(goal.position); // Set the destination to the goal position
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check if left mouse button was clicked
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Create a ray from the camera to the point where the mouse was clicked
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) // Check if the ray hit something
            {
                agent.SetDestination(hit.point); // Set the destination to the point where the ray hit
            }
        }
    }
}
