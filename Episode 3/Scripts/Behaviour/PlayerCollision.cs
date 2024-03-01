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

    [Header("INTERACT")]
    [SerializeField] Transform interactCheck;
    [SerializeField] LayerMask interactLayer;
    [SerializeField] float interactRadius;
    [SerializeField] bool interactGizmoz;

    public Collider[] INTERACT => Physics.OverlapSphere(interactCheck.position, interactRadius, interactLayer);
    public bool GROUND => Physics.Raycast(groundCheck.position, -transform.up, -groundDistance, groundLayer);

    private void OnDrawGizmos() 
    {
        if(groundGizmoz)
        {
            if(GROUND) Gizmos.color = Color.green;
            else Gizmos.color = Color.red;

            Gizmos.DrawRay(groundCheck.position, -transform.up * -groundDistance);
        }
        if(interactGizmoz)
            if(INTERACT.Length > 0)
                Gizmos.color = Color.green;
            else
                Gizmos.color = Color.red;

            Gizmos.DrawWireSphere(interactCheck.position, interactRadius);
        } 
    }
