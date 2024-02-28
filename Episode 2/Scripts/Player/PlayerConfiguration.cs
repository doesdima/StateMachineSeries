using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConfiguration : MonoBehaviour
{
    [Header("CONFIG")]
    [SerializeField] float moveSpeed;
    public float MOVESPEED => moveSpeed;

    [SerializeField] float turnSpeed;
    public float TURNSPEED => turnSpeed;

    [SerializeField] float jumpForce;
    public float JUMPFORCE => jumpForce;
}
