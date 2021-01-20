using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : MonoBehaviour
{
    private RaycastHit hit;
    private new LineRenderer renderer;

    [Range(3.0f, 20.0f)]
    public float maxDistance = 10.0f;

    public Transform laserMarker;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
        {
            renderer.SetPosition(1, new Vector3(0, 0, hit.distance));
            //레이저 마커의 위치를 레이저 끝지점으로 이동
            laserMarker.position = hit.point;

            //레이저 마커의 각도
            laserMarker.rotation = Quaternion.LookRotation(hit.normal);

            if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
            {
                transform.position = hit.point;
            }
        }
        else
        {
            renderer.SetPosition(1, new Vector3(0, 0, maxDistance));

            laserMarker.position = transform.position + (transform.forward * maxDistance);
            laserMarker.rotation = Quaternion.LookRotation(transform.forward);
        }
    }
}
