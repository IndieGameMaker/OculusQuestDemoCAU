using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : MonoBehaviour
{
    private RaycastHit hit;
    private LineRenderer renderer;

    [Range(3.0f, 20.0f)]
    public float maxDistance = 10.0f;

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

        }
    }
}
