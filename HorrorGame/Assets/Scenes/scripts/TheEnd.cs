using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEnd : MonoBehaviour
{
    [SerializeField]
    private KeyPickUp keyPickUp = null;
    
    [SerializeField] AudioSource kilitAcma;

    private void OnTriggerEnter(Collider other)
    {
        if (keyPickUp.haveKey)
        {
            kilitAcma.Play();
            AudioSource.DontDestroyOnLoad(this.kilitAcma);
            SceneManager.LoadScene("TheEnd");
        }
    }
}
