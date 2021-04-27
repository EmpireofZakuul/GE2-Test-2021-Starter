using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour
{
    public float tailWagRate;
    public float tailRadius;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.Euler(0, tailRadius, 0), tailWagRate);
        if (transform.localRotation == Quaternion.Euler(0, tailRadius, 0)) tailRadius = -tailRadius;
        // transform.localEulerAngles = transform.localEulerAngles(Mathf.Sin(Time.deltaTime * tailWagRate) * tailWagAmplitude);
    }
}
