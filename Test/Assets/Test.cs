using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public string test = "¿¬½À";
    public float speed = 1f;

    private void Awake()
    {
        test = "3333";
        Debug.Log(test);
    }
    void Start()
    {
        test = "2222";
        Debug.Log(test);

        Debug.Log(this.gameObject);
    }

    void Update()
    {
        this.gameObject.transform.Translate(new Vector3(0f, 0f, 1f * speed* Time.deltaTime));
        Debug.Log(this.gameObject.transform);
    }
}
