using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlaneScript : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
            Destroy(col.gameObject);
        if (col.gameObject.tag == "Enemy")
            Destroy(col.gameObject);
    }
}
