using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csParticle : MonoBehaviour
{
    public Object Particle1;
    public Object Particle2;
    public Object Particle3;
    public Object Particle4;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Object effectIns1 = Instantiate(Particle1, transform.position, transform.rotation);
            Destroy(effectIns1, 3f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Object effectIns2 = Instantiate(Particle2, transform.position, transform.rotation);
            Destroy(effectIns2, 3f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Object effectIns3 = Instantiate(Particle3, transform.position, transform.rotation);
            Destroy(effectIns3, 3f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Object effectIns4 = Instantiate(Particle4, transform.position, transform.rotation);
            Destroy(effectIns4, 3f);
        }
    }
}
