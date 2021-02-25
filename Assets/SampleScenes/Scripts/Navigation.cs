using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;

    public Transform house;

    public GameObject fp;
    public Vector3 m, n;
    public Vector3 destination = new Vector3(41, 0, 120);

    // Start is called before the first frame update
    void Start()
    {
        agent = this.transform.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(destination);
        m = fp.transform.position;
        n = this.transform.position;
        if(Vector3.Distance(m, n) > 10 || Vector3.Distance(n, destination) < 5)
        {
            agent.isStopped = true;
        }
        else if(agent.isStopped = true && Vector3.Distance(m, n) < 10 && Vector3.Distance(n, destination) > 5)
        {
            agent.isStopped = false;
        }
    }
}

