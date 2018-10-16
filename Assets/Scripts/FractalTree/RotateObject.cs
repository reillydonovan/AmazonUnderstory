﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

    public float angle = 30;
    public void Generated(int index)
    {
        this.transform.rotation *= Quaternion.Euler(angle * ((index * 2) -1), 0, angle * ((index * 2) - 1));
    }

}
