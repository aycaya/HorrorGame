using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    public AudioSource Scream;
    public GameObject ThePlayer;
    public GameObject JumpCam;
    public GameObject FlashImg;
    public GameObject ActualCam;
    private void OnTriggerExit(Collider other)
    {
        if (!Scream.isPlaying)
        {
            Scream.Play();
        }
        
        ActualCam.SetActive(false);
        JumpCam.SetActive(true);
        //ThePlayer.SetActive(false);
        FlashImg.SetActive(true);
        StartCoroutine(EndJump());

    }
    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(3f);
        Scream.Stop();
        ActualCam.SetActive(true);
        //ThePlayer.SetActive(true);
        JumpCam.SetActive(false);
        FlashImg.SetActive(false);
        Destroy(this.gameObject);
    }
}
