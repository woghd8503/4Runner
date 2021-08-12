using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCollision1 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌");
    }

    /*    private void OnTriggerEnter(Collider other)
        {
            Debug.Log("발생");
        }*/

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("닿이는중");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("충돌끝");
    }
}
