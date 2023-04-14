using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LastDoor : MonoBehaviour
{ 
    public GameObject TheDoor;
    [SerializeField]
    private KeyPickUp keyPickUp = null;
    public TextMeshProUGUI ActionText;
    
    [SerializeField] private GameObject exitSign;
    public AudioSource doorCreak;
   
    void OnTriggerExit(Collider other)
    {
        if (keyPickUp.haveKey) {
            TheDoor.GetComponent<Animator>().SetTrigger("lastDoor");
            exitSign.SetActive(true);
            if (!doorCreak.isPlaying)
            {
                doorCreak.Play();
                Destroy(this.gameObject);
            }
            
        }
        else if (keyPickUp.haveKey == false)
        {
            StartCoroutine(DeleteCoroutine());
        }
        
    }
    IEnumerator DeleteCoroutine()

    {

        ActionText.text = "Hala anahtarýn yok geri dönmelisin.";
        yield return new WaitForSeconds(5f);
        ActionText.text = "";
    }
}
