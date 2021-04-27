using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentBall : MonoBehaviour
{
    public bool hasBall = false;
    public GameObject dog;
    public void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Ball" && !hasBall)
        {
           
            other.transform.parent = dog.transform;
            hasBall = true;
        }
    }

}
