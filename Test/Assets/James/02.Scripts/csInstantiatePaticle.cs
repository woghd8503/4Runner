using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csInstantiatePaticle : MonoBehaviour
{
    private int particleNum = -1;
    public Transform[] spawnPoint;
    public GameObject[] paticles;
    public int randSpawn = -1;
    private void Awake()
    {
        randSpawn = Random.Range(0, 4);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            particleNum = 0;
            DoParticle();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            particleNum = 1;
            DoParticle();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            particleNum = 2;
            DoParticle();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            particleNum = 3;
            DoParticle();
        }
    }

    private void DoParticle()
    {
        GameObject particleObj = Instantiate(paticles[particleNum]) as GameObject;
        particleObj.transform.position = spawnPoint[randSpawn].position;

        Destroy(particleObj, 1.0f);
    }
}
