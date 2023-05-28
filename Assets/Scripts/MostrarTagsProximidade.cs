using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarTagsProximidade : MonoBehaviour
{
    private float distacia;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("ARCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        distacia=Vector3.Distance(cam.transform.position, transform.position);
        if(distacia <5)
        {
            transform.LookAt(Vector3.zero);
            transform.LookAt(cam.transform);
            transform.localScale = new Vector3(-0.3f, 0.3f, 0.3f);
        }
        else
        {
            transform.localScale = new Vector3(0f, 0f, 0f);
        }
    }
}
