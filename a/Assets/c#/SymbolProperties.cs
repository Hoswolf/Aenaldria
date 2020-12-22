using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SymbolProperties : MonoBehaviour,IPointerDownHandler,IDragHandler,IBeginDragHandler,IEndDragHandler
{
    public int num;
    public int index;

    public bool Have;
    public bool InAct;
    public bool Interactable;
    public bool InLine;

    public Collider2D col;

    public GameObject Him;
    public GameObject Line;
    

    private LineRenderer LR;
    
    public Transform Origin;

    Transform parent;
    Transform Content1;
   
    void Start()
    {
        InLine = false;
        InAct = false;
        Have = false;
        transform.localScale = new Vector3(1, 1, 0);
        parent = GameObject.FindGameObjectWithTag("Lienzo").transform;
        Content1 = GameObject.FindGameObjectWithTag("Content1").transform;
        index = transform.GetSiblingIndex();


    }
  /*  public void OnPointerClick(PointerEventData eventData)
    {
       if (eventData.button == PointerEventData.InputButton.Right)
        {
            var NewLine = Instantiate(Line, transform.position, Quaternion.identity);
            NewLine.transform.SetParent(transform);
            NewLine.transform.localScale = new Vector3(1, 1, 1);
            LR = NewLine.GetComponent<LineRenderer>();
          
            InLine = true;
            
        }



    }
  */
        public void OnBeginDrag(PointerEventData eventData)
    {
      //  Debug.Log("Dragged");
        if (Interactable == true)
        {
            transform.SetParent(parent);
            InAct = true;
        }
    }
   public void OnDrag(PointerEventData eventData)
    {
       // Debug.Log("Drag");
        if (Interactable == true)
        {
            Have = true;
        }

    }
    public void OnEndDrag(PointerEventData eventData)
    {
     //   Debug.Log("EndDrag");
        if (Interactable == true)
        {
            Have = false;
        }
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
      //  Debug.Log("PointerDown");
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
        if(InLine == false)
        {

            col.enabled = true;
        }
        if(InAct == true)
        {
            Interactable = true;
            gameObject.GetComponent<Button>().interactable = true;
        }
    /*   if(InLine == true)
        {
            col.enabled = false;

            Vector2 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           

            LR.SetPosition(1, wp);
         
            if (Input.GetMouseButtonDown(0))
            {
 RaycastHit2D hit = Physics2D.Raycast( LR.transform.position,Camera.main.ScreenToWorldPoint(Input.mousePosition));
            if(hit.collider != null)
            {
                Debug.Log(GameObject.Find(hit.collider.gameObject.name));
                    LR.SetPosition(1, hit.collider.gameObject.transform.position);
                    InLine = false;
            }
            }
             LR.SetPosition(0,Origin.position);
        
            }*/
        
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
