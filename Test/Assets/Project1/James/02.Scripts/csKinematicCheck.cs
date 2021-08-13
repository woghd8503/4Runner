using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class csKinematicCheck : MonoBehaviour
{
    private GameObject player = null;
    private int cnt = 0;
    private Text timeRecord;

    private void Start()
    {
        timeRecord = GameObject.Find("Time").GetComponent<Text>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("IsKinematicCheck");

            GetComponent<Rigidbody>().isKinematic = false;

            System.DateTime.Now.ToString("yyyy");
            string time = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            cnt += 1;
            string message = ($"{cnt} 번째\n 충돌 시간:{time}");
            Debug.Log(message);
            timeRecord.text = message;
        }
    }
}
