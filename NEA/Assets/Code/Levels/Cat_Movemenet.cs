using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat_Movemenet : MonoBehaviour
{
    public Rigidbody rb;
    public float P1X = 0f;
    public float P1Y = 0f;
    public float P1Z = 0f;
    public float P2X = 0f;
    public float P2Y = 0f;
    public float P2Z = 0f;
    private Vector3 point1;
    private Vector3 point2;
    public float speed = 0.3f;

    void Start()
    {
        point1 = new Vector3(P1X, P1Y, P1Z);
        point2 = new Vector3(P2X, P2Y, P2Z);
    }

    void Update()
    {
        transform.position = Vector3.Lerp(point1, point2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
