﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 30f;
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * speed);
    }
}
