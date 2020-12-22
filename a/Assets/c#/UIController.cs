using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    //a per cambiar de mode,ho indica en el text
    public GameObject[] Symbol;
    public GameObject Lienzo;
    public GameObject LineR;

 

    public Text Indicator;
    
    public int Num;
    public int Item_Num;
    public int Line;
    
   
    public bool Swipe;
 



    void Start()
    {
        Line = 0;
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
    public void LineAble()
    {

        Line = 0;
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
        if(Line == 0)
        {
 if (Input.GetKeyDown(KeyCode.L))
        {
                var NewLine = Instantiate(LineR, transform.position, Quaternion.identity);
               // NewLine.transform.SetParent(transform);
                NewLine.transform.localScale = new Vector3(1, 1, 1);
              
               
            Indicator.text = "Line";
            Item_Num = 2;
                Line = 1;
               
        }
        }


    }






}
