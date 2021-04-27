using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    public float fireRate = 15f;
    private float nextTimeToFire = 0f;
    public GameObject ball;
    public float speed = 20;
    public Transform Hand;
    public GameObject dog;
    public Transform player;
    public Tail Tail;
 

    public void Start()
    {
        dog = GameObject.Find("dog");
    }
    // Start is called before the first frame update
    void Update()
    {
        

        if (BallCheck.ballThrown == false)
        {


            if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1 / fireRate;
                Shoot();
                BallCheck.ballThrown = true;
            }
        }


     
    }
    public void Shoot()
    {
       // dog.GetComponentInChildren<Seek>().enabled = true;
        //dog.GetComponentInChildren<Arrive>().enabled = false;
        GameObject gren = Instantiate(ball, Hand.position, Hand.rotation) as GameObject;
        gren.GetComponent<Rigidbody>().AddForce(Hand.forward * speed, ForceMode.Impulse);
        dog.GetComponentInChildren<Seek>().targetGameObject = gren;
        Tail.tailWagRate = 5;
      

        DogState.state = DogState.Dog.seek;
    }


}
