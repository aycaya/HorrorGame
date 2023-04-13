using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    //public AudioSource
    public AudioSource doorCreak;
    //public GameObject TheZombie;
    public GameObject TheDoor;
    // Start is called before the first frame update
    void OnTriggerExit(Collider other)
    {
        TheDoor.GetComponent<Animator>().SetBool("keyDoor", true);
        if (!doorCreak.isPlaying)
        {
            doorCreak.Play();
            Destroy(this.gameObject);
        }

        //DoorBang.GetComponent<AudioSource>().Play();
        //Destroy(this.gameObject);
    }
}
