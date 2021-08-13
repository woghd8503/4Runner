using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("출돌 감지 시작");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("충돌 감지 중");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("충돌 감지 끝");
    }



}
