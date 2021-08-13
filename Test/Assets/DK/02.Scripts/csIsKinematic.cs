using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csIsKinematic : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("kinematic ¹ß»ý");
    }
}
