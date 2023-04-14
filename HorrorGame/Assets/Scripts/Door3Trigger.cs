using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3Trigger : MonoBehaviour
{ 
    public GameObject TheDoor;
    public AudioSource doorCreak;
    void OnTriggerExit(Collider other)
    {
        TheDoor.GetComponent<Animator>().SetBool("open", true);
        if (!doorCreak.isPlaying)
        {
            doorCreak.Play();
            Destroy(this.gameObject);
        }

        
    }
}
