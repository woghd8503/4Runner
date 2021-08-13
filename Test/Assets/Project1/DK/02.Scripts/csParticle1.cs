using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csParticle1 : MonoBehaviour
{
    public Object particle1;
    public Object particle2;
    public Object particle3;
    public Object particle4;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
         Object delparticle1 = Instantiate(particle1, transform.position, transform.rotation);
            Destroy(delparticle1, 2f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Object delparticle2 = Instantiate(particle2, transform.position, transform.rotation);
            Destroy(delparticle2, 2f);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            Object delparticle3 = Instantiate(particle3, transform.position, transform.rotation);
            Destroy(delparticle3, 2f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Object delparticle4 = Instantiate(particle4, transform.position, transform.rotation);
            Destroy(delparticle4, 2f);
        }
    }
}
