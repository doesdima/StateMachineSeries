using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [Header("GROUND")]
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] float groundDistance;
    [SerializeField] bool groundGizmoz;

    public bool GROUND => Physics.Raycast(groundCheck.position, -transform.up, -groundDistance, groundLayer);

    private void OnDrawGizmos() 
    {
        if(groundGizmoz)
        {
            if(GROUND) Gizmos.color = Color.green;
            else Gizmos.color = Color.red;

            Gizmos.DrawRay(groundCheck.position, -transform.up * -groundDistance);
        }
    } 
}
