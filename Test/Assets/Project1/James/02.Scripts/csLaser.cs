using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csLaser : MonoBehaviour
{
    private Ray shootRay;
    private RaycastHit shootHit;
    private LineRenderer lineRenderer;
    [SerializeField]
    private float distance = 0f;
    public AudioSource audioSource;
    public GameObject particle;

    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        Shoot(0f, false);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
            Shoot(100f, true);
        if (Input.GetMouseButtonUp(0))
            Shoot(0f, false);
    }

    void Shoot(float _distance, bool isPlay)
    {
        lineRenderer.SetPosition(0, transform.position);
        shootRay.origin = transform.position;
        shootRay.direction = transform.forward;
        distance = _distance;

        if (isPlay == true)
            audioSource.Play();
        else
            audioSource.Stop();

        if (Physics.Raycast(shootRay, out shootHit))
        {
            Vector3 v3Pos = shootRay.GetPoint(shootHit.distance * distance);
            lineRenderer.SetPosition(1, v3Pos);

            GameObject particleObj = Instantiate(particle) as GameObject;
            particleObj.transform.position = shootHit.point;

            Destroy(particleObj, 1.0f);
        }
    }
}
