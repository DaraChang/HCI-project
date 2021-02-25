using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Navigation : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;

    public Transform house;

    public Vector3 m, n;

    // Start is called before the first frame update
    void Start()
    {
        agent = this.transform.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(new Vector3(41, 0, 120));
    }
}

