using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolGenerator : MonoBehaviour
{
    public GameObject Circle;
    public GameObject Circle_Impostor;
    public GameObject Object;

    public float degree;
    public float a;

    public float c;
    public float Aprove;
    
    public int b;
    public int f;

   
    public bool Stopper;

    // Start is called before the first frame update
    void Start()
    {
        Stopper = false; b = Random.Range(3,6);
    }
    public void GenerateCircle() 
    {
        if (f == 1) 
        {  
            Instantiate(Circle, Object.transform.position, Quaternion.identity);
        }
       



    }
    // Update is called once per frame
    void Update()
    { 
        a = transform.rotation.eulerAngles.z;
       
        transform.eulerAngles += new Vector3( 0, 0,degree);

        Aprove += Time.deltaTime * f*100;
       

            if(Aprove <=b)
            {
               GenerateCircle();
            f = 1;

        }
        if (Aprove >= b)
        {
            
        }

 


         


       



    }
}
