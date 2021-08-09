using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csBullet : MonoBehaviour
{
    private Transform target;
    private float speed = 70f;
    public Object impactEffect;
    
    public void Seek(Transform _target)
    {
        target = _target;
    }
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        float Frame = speed * Time.deltaTime;
        transform.Translate(dir.normalized * Frame, Space.World);
        transform.LookAt(target);
    }
}
