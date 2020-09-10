using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dad : MonoBehaviour
{
    //This code spins the object infinitly, currently cannot get to only spin once
    public float speed = 0.33f;

    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            var spin = new Vector3(0f, 360f, 0f);
            transform.Rotate(spin * speed * Time.deltaTime);
        }
    }
}
