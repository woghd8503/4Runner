using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public string test = "¿¬½À";
    private void Awake()
    {
        test = "3333";
        Debug.Log(test);
    }
    void Start()
    {
        test = "2222";
        Debug.Log(test);
    }

    void Update()
    {
        
    }
}
