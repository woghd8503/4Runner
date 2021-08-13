using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csBullet2 : MonoBehaviour
{
    public Object Bulletparticle;

    float power = 1000.0f;
    Vector3 velocity = new Vector3(0.0f, 0.3f, 0.5f);

    void Start()
    {
        velocity = velocity * power;
        GetComponent<Rigidbody>().AddForce(velocity);
    }
    void FixedUpdate()
    {     
            Destroy(this.gameObject,1.5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Object BulletParticleEf = Instantiate(Bulletparticle, transform.position, transform.rotation);
        Destroy(BulletParticleEf, 2f);
    }
}

