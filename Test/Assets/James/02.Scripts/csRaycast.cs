using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRaycast : MonoBehaviour
{
    private float speed = 5.0f;

    void Update()
    {
        float amtMove = speed * Time.deltaTime;
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * hor * amtMove);
        transform.Translate(Vector3.forward * ver * amtMove);

        Debug.DrawRay(transform.position, transform.forward * 8, Color.red);

        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
