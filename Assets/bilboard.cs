﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bilboard : MonoBehaviour
{
    public Transform camera;
    void LateUpdate()
    {

        transform.LookAt(transform.position + camera.forward);

    }
}
