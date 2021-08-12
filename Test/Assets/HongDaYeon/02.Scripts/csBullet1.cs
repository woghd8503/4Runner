using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csBullet1 : MonoBehaviour
{
    public Object Particle;
    void Update()
    {
        transform.Translate(Vector3.forward  * 0.2f);

        Destroy(gameObject,2f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Object ParticlePoint = Instantiate(Particle, transform.position, transform.rotation);
        Destroy(ParticlePoint, 1f);
    }
}
