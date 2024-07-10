using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class RespawnItem : MonoBehaviour
{
    private Vector3 respawnLocation = new Vector3 (0.306f,1.332f,3.355f);
    public GameObject replacement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider c)
    {
        if(c.transform.tag == "DeathZone")
        {
            Instantiate(replacement, respawnLocation, quaternion.identity);
            Destroy(this.gameObject);
        }
        
    }
}
