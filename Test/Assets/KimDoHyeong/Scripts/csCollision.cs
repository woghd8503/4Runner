using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision 충돌시작!");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collision 충돌중!");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collsion 충돌끝!");
    }
}
