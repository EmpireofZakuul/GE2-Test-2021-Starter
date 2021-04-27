using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour
{
    public float tailWagRate;
    public float tailWagAmplitude;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
       // transform.localEulerAngles = transform.localEulerAngles(Mathf.Sin(Time.deltaTime * tailWagRate) * tailWagAmplitude);
    }
}
