using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogState : MonoBehaviour
{

    public enum Dog { seek, fetch, drop, wait}

    public GameObject player;
    public GameObject dog;

    public static Dog state;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case Dog.wait:
                dog.GetComponentInChildren<Seek>().enabled = false;
                break;
            case Dog.seek:
                dog.GetComponentInChildren<Seek>().enabled = true;
                dog.GetComponentInChildren<Arrive>().enabled = false;
                break;
            case Dog.fetch:
                dog.GetComponentInChildren<Seek>().enabled = false;
                dog.GetComponentInChildren<Arrive>().enabled = true;
                break;
            case Dog.drop:
                Destroy(GameObject.FindGameObjectWithTag("Ball"));
                dog.GetComponentInChildren<ParentBall>().hasBall = false;
                BallCheck.ballThrown = false;
                Debug.Log("ball dropped");
                break;
        } 
    }
}
