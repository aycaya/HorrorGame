using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2Trigger : MonoBehaviour
{
    public AudioSource doorCreak;
    public GameObject TheZombie;
    public GameObject TheDoor;
    // Start is called before the first frame update
    void OnTriggerExit(Collider other)
    {
        TheDoor.GetComponent<Animator>().SetBool("door2Open", true);
        if (!doorCreak.isPlaying)
        {
            doorCreak.Play();
            Destroy(this.gameObject);
        }
    }
}
