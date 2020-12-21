using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SymbolProperties : MonoBehaviour,IPointerDownHandler,IDragHandler,IBeginDragHandler,IEndDragHandler, IPointerClickHandler
{
    public int num;
    public int index;

    public bool Have;
    public bool InAct;
    public bool Interactable;
    public GameObject Him;
    
    Transform parent;
    Transform Content1;
   
    void Start()
    {
        InAct = false;
        Have = false;
        transform.localScale = new Vector3(1, 1, 0);
        parent = GameObject.FindGameObjectWithTag("Lienzo").transform;
        Content1 = GameObject.FindGameObjectWithTag("Content1").transform;
        index = transform.GetSiblingIndex();


    }
    public void OnPointerClick(PointerEventData eventData)
    {
       if (eventData.button == PointerEventData.InputButton.Right)
        {

        }



    }
        public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Dragged");
        if (Interactable == true)
        {
            transform.SetParent(parent);
            InAct = true;
        }
    }
   public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag");
        if (Interactable == true)
        {
            Have = true;
        }

    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("EndDrag");
        if (Interactable == true)
        {
            Have = false;
        }
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("PointerDown");
        if(Interactable == true)
        {
if (InAct == false)
        {
 var NewSymbol= Instantiate(gameObject,transform.position, Quaternion.identity);
        NewSymbol.transform.SetParent(Content1.transform);
                NewSymbol.transform.SetSiblingIndex(index); 

        }
        }
        
       
      
    }

    private void Update()
    {
        num = PlayerPrefs.GetInt("Mode");
        if(num == 0 )
        {
           
            if (InAct == false)
            { Interactable = false;
                gameObject.GetComponent<Button>().interactable = false;
            }
        }
        if (num == 1)
        {
           
            if(InAct == false)
            { Interactable = true;
   gameObject.GetComponent<Button>().interactable = true;
            }
         
        }
        if(InAct == true)
        {
            Interactable = true;
            gameObject.GetComponent<Button>().interactable = true;
        }   

    }
    private void FixedUpdate()
    {
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Have == true)
        {
 
        Him.transform.position = worldPosition;

        }
        if (Input.GetKeyDown(KeyCode.F) && Have == true)
        {
            Destroy(gameObject);
        } 
    }
   
}
