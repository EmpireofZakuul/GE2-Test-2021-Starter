using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Arrive : SteeringBehaviour
{
    public Vector3 targetPosition = Vector3.zero;
    public float slowingDistance = 15.0f;
    public Transform player;
    public Transform dog;
    public GameObject targetGameObject = null;
    public ParentBall parent;
    public Boid myBoid;

    public override Vector3 Calculate()
    {
        return boid.ArriveForce(targetPosition, slowingDistance);
    }

    public void Update()
    {
        if (targetGameObject != null)
        {
            targetPosition = new Vector3(targetGameObject.transform.position.x, 0f, targetGameObject.transform.position.z);
        }

        if(Vector3.Distance(player.transform.position, dog.transform.position) <= 10)
        {
            dog.GetComponentInChildren<Arrive>().enabled = false;

            //Vector3 stop = new Vector3.zero;
            //parent.myCollider.transform.SetParent(null);
            //ball = dog.GetComponent<Seek>().targetGameObject.transform;
            //ball.SetParent(null);

            boid.velocity = Vector3.zero;
            boid.acceleration = Vector3.zero;
            boid.force = Vector3.zero;
         
          

        }
    }
}