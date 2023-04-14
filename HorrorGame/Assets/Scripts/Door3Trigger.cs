using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3Trigger : MonoBehaviour
{ 
    //public AudioSource
    //public GameObject TheZombie;
    public GameObject TheDoor;
    // Start is called before the first frame update
    public AudioSource doorCreak;
    void OnTriggerExit(Collider other)
    {
        TheDoor.GetComponent<Animator>().SetBool("open", true);
        if (!doorCreak.isPlaying)
        {
            doorCreak.Play();
            Destroy(this.gameObject);
        }

        //DoorBang.GetComponent<AudioSource>().Play();
        //Destroy(this.gameObject);
    }
}
