using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsoluteArrow : MonoBehaviour
{
    public Transform destination;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(destination);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(destination);
    }
}