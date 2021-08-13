using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRaycast1 : MonoBehaviour
{
    public GameObject Bullet;
    public Transform firepoint;

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 50, Color.green);
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.forward,out hit))
        {
                if (Input.GetButtonDown("Fire1"))
                {
                    Shoot();
                }
        }

        void Shoot()
        {
            GameObject bulletGo = Instantiate(Bullet, firepoint.position, firepoint.rotation);
        }
    }
}
