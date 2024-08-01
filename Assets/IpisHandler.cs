using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IpisHandler : MonoBehaviour
{
    public GameObject pandesal;
    public AudioClip damageSoundClip;

    // Start is called before the first frame update
    void Start()
    {
        if (pandesal == null)
            pandesal = GameObject.FindGameObjectWithTag("Pandesal");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, pandesal.transform.position, 0.5f * Time.deltaTime);
    }


    
    void OnCollisionEnter(Collision c)
    {
        if(c.transform.tag == "Slipper")
            SoundFXManager.instance.PlaySoundFXClip(damageSoundClip, transform, 1f);
        Destroy(this.gameObject);
    }
}
