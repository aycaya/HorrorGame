using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseZombie : MonoBehaviour
{
    [SerializeField] AudioSource closeZombie;
    [SerializeField] bool isClose=false;
    
    private void OnTriggerExit(Collider other)
    {
        if (isClose) { 
         if (!closeZombie.isPlaying)
        {
            closeZombie.Play();
            Destroy(this.gameObject);


        }}
        else if (!isClose)
        {
            closeZombie.Stop();
            Destroy(this.gameObject);
        }
    }
}
