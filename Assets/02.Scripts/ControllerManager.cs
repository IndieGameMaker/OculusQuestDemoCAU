using System.Collections;
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
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, leftController))
        {
            Debug.Log("왼손 Index Trigger !!");
        }
        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger, rightController))
        {
            Debug.Log("오른손 Index Trigger !!");
        }

        if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger, rightController))
        {
            Debug.Log("햅틱 !!!");
            OVRInput.SetControllerVibration(1.0f, 1.0f, rightController);
        }
    }
}
