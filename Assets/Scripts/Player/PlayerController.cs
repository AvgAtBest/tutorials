using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;
/*
 * The PlayerController handles player movement & rotation logic
 */
public class PlayerController : MonoBehaviour
{
    public NavMeshAgent agent; // reference to NavMeshAgent component

    //Calls this to tell agent where to go.
    public void SetDestination(Vector3 target)
    {
        //NavMesh path creates a new instances of path to contain the new path
        NavMeshPath path = new NavMeshPath();
        //Calculates the new path to the target
        if (agent.CalculatePath(target, path))
        {
            //if the path generates is completed
            if (path.status == NavMeshPathStatus.PathComplete)
            {
                //Agent goes to the target destination
                agent.SetDestination(target);
            }
        }
    }
}
