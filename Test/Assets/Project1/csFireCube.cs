using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csFireCube : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().isKinematic = false;
            Fire();
        }
    }
    public void Fire()
    {
        Vector3 speed = new Vector3(0, 200, 2000);
        GetComponent<Rigidbody>().AddForce(speed);
    }
}
