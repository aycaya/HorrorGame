using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorLocked : MonoBehaviour
{
    [SerializeField]
    private KeyPickUp keyPickUp = null;
    public TextMeshProUGUI ActionText;
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

    }
    IEnumerator DeleteCoroutine()
    {
        ActionText.text = "Kapý kilitli anahtarý bulmalýsýn.";
        yield return new WaitForSeconds(5f);
        ActionText.text = "";
    }
}
