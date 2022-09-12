using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelRotation : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private BulletBehaviour bulletPrefab;
    [SerializeField] private Transform firePoint;
    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        transform.up = mousePosition;
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, firePoint.position, Quaternion.identity); 
        }
    }
}
