using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    NavMeshAgent agent;
    RaycastHit raycastHit;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(r,out raycastHit,Mathf.Infinity))
            {
                agent.SetDestination(raycastHit.point);
            }
        }
        
    }
}
