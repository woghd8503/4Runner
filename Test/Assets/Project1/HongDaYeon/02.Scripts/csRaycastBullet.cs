using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRaycastBullet : MonoBehaviour
{
    
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 20, Color.red);

        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, 20.0f);

        for (int i = 0; i<hits.Length; i++)
        {
            RaycastHit hit = hits[i];

            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
// 레이케스트가 큐브에 닿았을때 좌표 = 파티클 생성 좌표