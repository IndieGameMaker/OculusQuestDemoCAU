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
        /*
            1. Combine 방식
                PrimaryIndexTrigger - 왼손 트리거
                SecondaryIndexTrigger - 오른손

            2. Individual 방식
                PrimaryIndexTrigger, LTouch - 왼손
                PrimaryIndexTrigger, RTouch - 오른손

            3. RawMapping 방식
        */

        //Combine 방식
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("왼손 Index Trigger");
        }

        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            Debug.Log("오른손 Index Trigger");

            float value  = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);
            Debug.Log($"오른손 Index Value = {value}"); //Debug.Log("왼손 Index Value = " + value);
        }

        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            //OVRInput.SetControllerVibration(0.8f, 0.8f, OVRInput.Controller.RTouch);
            StartCoroutine(Haptic(0.2f));
        }

        //정전압을 이용한 터치
        if (OVRInput.Get(OVRInput.Touch.PrimaryThumbstick))
        {
            Vector2 pos = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
            Debug.Log($"pos = {pos.x},{pos.y}");
        }

        if (OVRInput.Get(OVRInput.Touch.SecondaryIndexTrigger))
        {
            Debug.Log("오른손 Index Trigger 터치 !!!");
        }

        //Individual 방식
        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
        {
            Debug.Log("왼손 Hand Trigger");
        }

        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
        {
            Debug.Log("오른손 Hand Trigger");
        }        
    }

    IEnumerator Haptic(float duration)
    {
        OVRInput.SetControllerVibration(0.8f, 0.8f, OVRInput.Controller.RTouch);

        yield return new WaitForSeconds(duration);

        OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
    }
}
