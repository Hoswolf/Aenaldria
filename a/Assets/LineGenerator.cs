using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour
{
    public LineRenderer LR;

    public bool UseA;
    public bool UseB;

    public GameObject UIC;

    private Transform A;
    private Transform B;

    void Start()
    {
        UseA = true;
        UseB = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (UseA == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(LR.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
                if (hit.collider != null)
                {
                    Debug.Log(GameObject.Find(hit.collider.gameObject.name));
                    LR.SetPosition(1, hit.collider.gameObject.transform.position);
                    A = hit.collider.GetComponent<Transform>();
                    UseA = false;
                }


            }
        }

        if (UseB == true)
        {
            if (Input.GetMouseButtonDown(1))
            {
                RaycastHit2D hit2 = Physics2D.Raycast(LR.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
                if (hit2.collider != null)
                {
                    Debug.Log(GameObject.Find(hit2.collider.gameObject.name));
                    LR.SetPosition(0, hit2.collider.gameObject.transform.position);
                    B = hit2.collider.GetComponent<Transform>();
                    UseB = false;

                }

            }
        }
        if(UseA == false && UseB == false)
        {
           UIC = GameObject.FindGameObjectWithTag("UIC");
            UIC.SendMessage("LineAble");

        }


        
       
        gameObject.transform.SetParent(A);

        LR.SetPosition(1, A.position);
        LR.SetPosition(0, B.position);





    }

}