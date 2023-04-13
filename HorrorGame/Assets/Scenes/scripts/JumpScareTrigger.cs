using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JumpScareTrigger : MonoBehaviour
{
    public AudioSource DoorBang;
  
    public GameObject TheDoor;
    public GameObject TheDoor2; 
    public TextMeshProUGUI ActionText;
    public GameObject player;
    public AudioClip doorBang;

   

    void OnTriggerExit(Collider other)
    {
       
        
        TheDoor.GetComponent<Animator>().SetBool("startNow",true);
        TheDoor2.GetComponent<Animator>().SetBool("startNow", true);
      
        if (!DoorBang.isPlaying)
        {
            DoorBang.Play();
            Destroy(this.gameObject);
            
            
        }
        
        

       
    }

   
}
