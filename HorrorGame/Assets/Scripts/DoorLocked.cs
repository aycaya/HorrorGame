using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorLocked : MonoBehaviour
{
    [SerializeField]
    private KeyPickUp keyPickUp = null;
    public TextMeshProUGUI ActionText;
    // Start is called before the first frame update
    void OnTriggerExit(Collider other)
    {
        
        if (keyPickUp.haveKey == false)
        {
            StartCoroutine(DeleteCoroutine());
        }
        else if (keyPickUp.haveKey)
        {
            Destroy(this.gameObject);
        }
        //DoorBang.GetComponent<AudioSource>().Play();
        //Destroy(this.gameObject);
    }
    IEnumerator DeleteCoroutine()

    {
        //yield return new WaitForSeconds(doorBang.length);
        //Destroy(DoorBang.gameObject);

        ActionText.text = "Kapý kilitli anahtarý bulmalýsýn.";
        yield return new WaitForSeconds(5f);
        ActionText.text = "";
        //Destroy(this.gameObject);
    }
}
