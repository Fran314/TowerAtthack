﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPoints : MonoBehaviour
{
    public static Transform[] points;
    public static int size;

    void Awake()
    {
        size = transform.childCount;
        points = new Transform[size];
        for(int i = 0; i < size; i++)
        {
            points[i] = transform.GetChild(i);
        }

        for(int i = 0; i < size - 1; i++)
        {
            points[i].GetComponent<PointScript>().next_point = points[i + 1];
        }
    }
}
