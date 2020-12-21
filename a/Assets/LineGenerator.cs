using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour
{
    public LineRenderer LineR;

    public Transform one;
    public Transform two;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
       LineR.SetPosition(0, new Vector3(one.transform.position.x, one.transform.position.y,one.transform.position.z));
        LineR.SetPosition(1, new Vector3(two.transform.position.x, two.transform.position.y, two.transform.position.z)); 
    }
}
