﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortcutScript : MonoBehaviour
{
    public Transform start = null;
    public Transform end = null;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals(TagManager.sc_virus_tag))
        {
            start.GetComponent<PointScript>().next_point = end;
            Destroy(gameObject);
        }
    }
}