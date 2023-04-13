using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door5 : MonoBehaviour
{
    
    public GameObject TheDoor;
    public AudioSource doorCreak;
   
    void OnTriggerExit(Collider other)
    {
        TheDoor.GetComponent<Animator>().SetBool("door5Open", true);
        if (!doorCreak.isPlaying)
        {
            doorCreak.Play();
            Destroy(this.gameObject);
        }

       
    }
}
