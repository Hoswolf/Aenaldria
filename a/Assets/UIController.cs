using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    //a per cambiar de mode,ho indica en el text
    public GameObject[] Symbol;
    public GameObject Lienzo;
    public int Num;
    public Text Indicator;
    public int Item_Num;
    public bool Swipe;

    void Start()
    {
        Indicator.text = "Lock";
        Swipe = false;
        Item_Num = 0;
        Num = 0;
    }
    public void SetSymbol(int A)
    {
        Num = A;

    }
   
    // Update is called once per frame
    void FixedUpdate()
    {  
       
        
    }

    private void Update()
    {
           PlayerPrefs.SetInt("Mode",Item_Num);
        if (Input.GetKeyDown(KeyCode.A))
        {
            Swipe = !Swipe;
            if (Swipe == true) 
            {
                Item_Num = 1;
              
                Indicator.text = "SymbolAdder";
            }
            if (Swipe == false)
            {
                Item_Num = 0;

                Indicator.text = "Lock";
            }


        }
    }








}
