using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCheck : MonoBehaviour
{
    public static bool ballThrown;
    public static bool dogHasBall;

    // Start is called before the first frame update
    void Awake()
    {
        ballThrown = false;
        dogHasBall = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
