using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class mipmap : MonoBehaviour
{
    public Transform[] pos;
    public Camera camera;
    public Material material;
    public NavMeshAgent nav;

    private Vector2 mipVec;
    private Ray ray;
    private RaycastHit hit;
    private Vector2[] vector;
    private float sizex, sizey;
    public RenderTexture texture;

    private void Awake()
    {
        vector = new Vector2[4];
    }
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < pos.Length; i++)
        {
            vector[i]=Camera.main.WorldToScreenPoint(pos[i].position);
        }
        sizex = vector[0].x - vector[2].x;
        sizey = vector[0].y - vector[1].y;
        texture = new RenderTexture((int)sizex, (int)sizey, 0);
        camera.targetTexture = texture;
        material.mainTexture = texture;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnMouseDown()
    {
        mipVec.x = Input.mousePosition.x - vector[2].x;
        mipVec.y = Input.mousePosition.y - vector[1].y;
        ray = camera.ScreenPointToRay(mipVec);
        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log("hiiiiiiiiiiiii");
            //GameObject a = Resources.Load<GameObject>("SampleScenes/Prefabs/Box");
            //Instantiate(a, hit.point, Quaternion.identity, null);
            nav.SetDestination(new Vector3(1, 0, -1));

        }
    }
}
