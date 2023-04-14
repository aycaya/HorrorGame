using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    public AudioSource doorCreak;
    public GameObject TheDoor;
    void OnTriggerExit(Collider other)
    {
        TheDoor.GetComponent<Animator>().SetBool("keyDoor", true);
        if (!doorCreak.isPlaying)
        {
            doorCreak.Play();
            Destroy(this.gameObject);
        }

    }
}
