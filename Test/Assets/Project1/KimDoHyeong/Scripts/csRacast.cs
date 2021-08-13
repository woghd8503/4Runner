using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRacast : MonoBehaviour
{
    public GameObject bullet;
    public Transform firepoint;
    private Transform target;
    
    void Target()
    {
        GameObject enemytag = GameObject.FindWithTag("Enemy");
        target = enemytag.transform;
    }


    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 50, Color.green);
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if(hit.transform.tag == "Enemy")
            {
                 shoot();
                 Debug.Log("Enemy");
            }
        }

        
    }
    void shoot()
    {
        GameObject bulletGo = Instantiate(bullet, firepoint.position, firepoint.rotation);
        csBullet csbullet = bulletGo.GetComponent<csBullet>();
        if (csbullet != null)
            csbullet.Seek(target);
            
    }
}
