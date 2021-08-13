using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csTrigger1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTrigger");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");

    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");

    }

}
