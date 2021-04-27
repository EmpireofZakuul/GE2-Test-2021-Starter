using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Seek : SteeringBehaviour
{
    public GameObject targetGameObject = null;

    public Vector3 target = Vector3.zero;
    public AudioSource AudioSource;
    public float timeRemaining = 2;
    public bool timerIsRunning = false;

    public void OnEnable()
    {
        //InvokeRepeating("Sound", 1f, 2f);
       // AudioSource.GetComponent<AudioSource>();
        timerIsRunning = true;
    }

   // void Sound()
    //{
       // AudioSource.Play();
   // }
    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            Gizmos.color = Color.cyan;
            if (targetGameObject != null)
            {
                target = targetGameObject.transform.position;
            }
            Gizmos.DrawLine(transform.position, target);
        }
    }

    public override Vector3 Calculate()
    {
        return boid.SeekForce(target);
    }

    public void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                AudioSource.Play();
                timeRemaining = 2;
                //timerIsRunning = false;
            }
        }
        if (targetGameObject != null)
        {
            target = new Vector3(targetGameObject.transform.position.x, 0f, targetGameObject.transform.position.z);
        }


    }
}