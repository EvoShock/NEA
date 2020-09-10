using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 newPosition = target.position + offset;
        transform.position = newPosition;
        transform.rotation = Quaternion.Euler(30, 45, 0);
    }
}