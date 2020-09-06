using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.EventSystems;


public class SkeletonController : MonoBehaviour
{
  
    public Text partname;
    public GameObject SkeletonParent;
    public Material deSelect;
    public Material Select;


    
    public  GameObject previousobj;
   

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
          
            if (Physics.Raycast(ray, out hit))
            {
               

                
                   hit.transform.gameObject.GetComponent<Renderer>().material = Select;
                 
                   partname.text = hit.transform.gameObject.name;
                if (!previousobj.gameObject)
                    {
                    
                     previousobj = hit.transform.gameObject;
                    }
                    else
                    {

                    previousobj.transform.gameObject.GetComponent<Renderer>().material = deSelect;
                    previousobj = hit.transform.gameObject;
                }
                   
                

               
             

              
                
            }
        }


    }


   




   


}
