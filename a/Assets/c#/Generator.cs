using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    //Animacio de amagar o ensenyar la finestra,ho faig amb animació pq només es amagar i ensenyar,pero sino no es recomana
    public Animator SymbolTab;

    public bool STabHide;
    
    void Start()
    {
        STabHide = false;
        
    }
    public void HideSymbols()
    {
        STabHide = !STabHide;
       if(STabHide == false)
        {
            SymbolTab.SetTrigger("Show");

        }
        if (STabHide == true)
        {
            SymbolTab.SetTrigger("Hide");

        }

    }
    
}
