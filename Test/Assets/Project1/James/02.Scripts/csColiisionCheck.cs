using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csColiisionCheck : MonoBehaviour
{
    Renderer wallColour;

    private void Start()
    {
        wallColour = gameObject.GetComponent<Renderer>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("CollisionEnter");
            if (wallColour.material.color != Color.blue)
            {
                wallColour.material.color = Color.blue;
            }
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("CollisionEnter");
            if (wallColour.material.color != Color.yellow)
            {
                wallColour.material.color = Color.yellow;
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("CollisionEnter");
            if (wallColour.material.color != Color.black)
            {
                wallColour.material.color = Color.black;
            }
        }
    }
}
