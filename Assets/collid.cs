using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collid : MonoBehaviour
{
    private MeshRenderer m_meshrenderer;
    // Start is called before the first frame update
    void Start() {
        // m_meshrenderer.material.color = Color.white;
        m_meshrenderer = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update() {

    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Cube") {
            // m_meshrenderer.material.color = Color.green;
            gameObject.GetComponent<MeshRenderer>().enabled =true;
        }
    }
}
