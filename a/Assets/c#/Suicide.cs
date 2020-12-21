using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suicide : MonoBehaviour
{
    //es per evitar que aparegui l'error de que no troba l'objecte en el element 0
    public GameObject a;
    void Start()
    {
        StartCoroutine(SuicideObject());
    }
    IEnumerator SuicideObject()
    {
        yield return new WaitForSeconds(1);
        Destroy(a);

    }
  
}
