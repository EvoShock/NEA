﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Running : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
