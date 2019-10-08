using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpinX : MonoBehaviour
{
    public float turnSpeed = 5f; 

    // Update is called once per frame
    void Update()
    {
        //spins propeller
        transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime);
    }
}
