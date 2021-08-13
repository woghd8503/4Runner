using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float speed = 5f;
    void Start()
    {
        
    }
    void Update()
    {
        this.gameObject.transform.Rotate(new Vector3(0f, 1f, 0f*speed*Time.deltaTime));
    }
}
