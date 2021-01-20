using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour
{
    public Image indexPressed;

    void Start()
    {
        
    }

    void Update()
    {
        if (OVRInput.Get(OVRInput.Touch.SecondaryIndexTrigger))
        {
            float rate = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger); //0.0f ~ 1.0f
            indexPressed.fillAmount = rate;
        }        
    }
}
