﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxSocket : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "fox")
        {
            Debug.Log("fox is here.");
        }
        else
        {
            Debug.Log("NOT A FOX HOVERING");
        }
    }

    //public void IsItAFox(Collider other)
    //{
    //    if (other.gameObject.tag == "fox")
    //    {
    //        Debug.Log("Yes, it's a fox hovering");
    //    }
    //    else
    //    {
    //        Debug.Log("NOT A FOX HOVERING");
    //    }

    //}

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
