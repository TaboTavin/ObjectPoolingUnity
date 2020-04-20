﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject cubePrefab;
    public float cubeForce=20f;
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
       {
            GameObject cube = PoolManager.sharedInstance.GetObjectFromPool(spawnPoint.position, spawnPoint.rotation);

            Rigidbody rb = cube.GetComponent<Rigidbody>();
            rb.AddForce(spawnPoint.up * cubeForce, ForceMode.Impulse);
       }
    }
}
