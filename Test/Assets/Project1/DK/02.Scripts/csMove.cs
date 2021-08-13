using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMove : MonoBehaviour
{
    float speed = 10.0f;

    private void Awake()
    {
        Debug.Log("시작");
    }
    private void Start()
    {
        Debug.Log("시작했다니깐");
    }

    void Update()
    {

        Debug.Log("시작했다니깐");

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        transform.Translate(Vector3.right * h);
        transform.Translate(Vector3.forward * v);
    }
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 5.0f, 0.0f);
        }
    }
}
