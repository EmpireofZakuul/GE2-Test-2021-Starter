using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentBall : MonoBehaviour
{
    public bool hasBall = false;
    public GameObject dog;
    public bool unParented = false;
    public Collider myCollider;
    public Transform parentObject;
    public GameObject ball;


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
            DogState.state = DogState.Dog.fetch;
        }
      
    }


}
