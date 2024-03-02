using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IInteractable
{

    [SerializeField] Rigidbody RB;

    public void Interact()
    {
        RB.velocity += Vector3.up * 10f;
    }
}