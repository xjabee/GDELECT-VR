using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class IpisSpawner : MonoBehaviour
{
    public GameObject ipis;
    public float repeatRate = 0f;
    void Start()
    {
        InvokeRepeating("SpawnIpis", 2.0f, repeatRate);
    }


    void SpawnIpis()
    {
        
        Instantiate(ipis, transform.position, Quaternion.identity);
    }

}
