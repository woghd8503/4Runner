using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csShotBullet : MonoBehaviour
{
    [SerializeField]
    private GameObject Bullet;
    public Transform SpawnPoint = null;
    private void Start()
    {
        Instantiate(Bullet, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
        Debug.Log("Position");
    }

    private void Update()
    {
       if(Input.GetMouseButtonDown(0))
       {
            Instantiate(Bullet, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
       }
    }
}
