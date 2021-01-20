﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerManager : MonoBehaviour
{
    public OVRInput.Controller leftController = OVRInput.Controller.LTouch;
    public OVRInput.Controller rightController = OVRInput.Controller.RTouch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
            1. Combine 방식
                PrimaryIndexTrigger - 왼손 트리거
                SecondaryIndexTrigger - 오른손

            2. Individual 방식
                PrimaryIndexTrigger, LTouch - 왼손
                PrimaryIndexTrigger, RTouch - 오른손

            3. RawMapping 방식
        */

        
    }
}
