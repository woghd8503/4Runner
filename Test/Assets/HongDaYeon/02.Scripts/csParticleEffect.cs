using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csParticleEffect : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject PraticleEffect01;
    public GameObject PraticleEffect02;
    public GameObject PraticleEffect03;
    public GameObject PraticleEffect04;
    void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            Debug.Log("키입력 : 1");
            GameObject particleObj = Instantiate(PraticleEffect01) as GameObject;
            particleObj.transform.position = SpawnPoint.position;
            Destroy(particleObj, 1f);
        }
        if (Input.GetKeyDown("2"))
        {
            Debug.Log("키입력 : 2");
            GameObject particleObj = Instantiate(PraticleEffect02) as GameObject;
            particleObj.transform.position = SpawnPoint.position;
            Destroy(particleObj, 1f);
        }
        if (Input.GetKeyDown("3"))
        {
            Debug.Log("키입력 : 3");
            GameObject particleObj = Instantiate(PraticleEffect03) as GameObject;
            particleObj.transform.position = SpawnPoint.position;
            Destroy(particleObj, 1f);
        }
        if (Input.GetKeyDown("4"))
        {
            Debug.Log("키입력 : 4");
            GameObject particleObj = Instantiate(PraticleEffect04) as GameObject;
            particleObj.transform.position = SpawnPoint.position;
            Destroy(particleObj, 1f);
        }
    }
}
