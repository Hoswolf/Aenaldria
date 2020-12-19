using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolProperties : MonoBehaviour
{
   // Aquest script serveix per detectar que quan cliquis el simbol perseguiexi el cursor. Per deixar anar l'objecte tecla z
    public bool Have;
    public GameObject Him;
   
    void Start()
    {
        Have = false;
        transform.localScale = new Vector3(1, 1, 0);
       
    }

   
    public void SetMousePos()
    {
        Have = !Have;
        
        
       

    }
    private void FixedUpdate()
    {
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Have == true)
        {
 
        Him.transform.position = worldPosition;

        }
        if (Input.GetKeyDown(KeyCode.Z) && Have == true)
        {
           Have = false;
        } 
    }
   
}
