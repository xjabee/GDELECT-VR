using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IpisHandler : MonoBehaviour
{
    public GameObject pandesal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, pandesal.transform.position, 0.5f * Time.deltaTime);
    }


    
    void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
