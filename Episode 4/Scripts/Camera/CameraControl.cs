using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] Vector3 offset;
    [SerializeField] float smoothTime;
    [SerializeField] Transform target;
    Vector3 velocity = Vector3.zero;

    Vector3 previousTargetPosition;

    private void Start()
    {
        transform.position = target.position + offset;
        previousTargetPosition = target.position;
    }

    private void LateUpdate()
    {
        if (target != null)
        {
            Vector3 targetMovement = target.position - previousTargetPosition;
            Vector3 targetPosition = new Vector3(target.position.x, 0, target.position.z) + offset + targetMovement;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
            previousTargetPosition = target.position;
        }
    }

}
