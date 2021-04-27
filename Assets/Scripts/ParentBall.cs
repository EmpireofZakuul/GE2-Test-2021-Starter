using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentBall : MonoBehaviour
{
    public bool hasBall = false;
    public GameObject dog;
    public bool unParented = false;
    public Collider myCollider;


    public void Start()
    {
        dog = GameObject.Find("dog");
    }
    public void OnTriggerEnter( Collider myCollider)
    {
       
        if (myCollider.gameObject.tag == "Ball" && !hasBall)
        {

            myCollider.transform.parent = dog.transform;
            hasBall = true;
            dog.GetComponentInChildren<Arrive>().enabled = true;
            dog.GetComponentInChildren<Seek>().enabled = false;
        }
      
    }
    public void Update()
    {
        if ( unParented)
        {
           // myCollider.transform.parent = null;
            myCollider.transform.SetParent(null);
            unParented = false;
            hasBall = false;
        }
    }

}
