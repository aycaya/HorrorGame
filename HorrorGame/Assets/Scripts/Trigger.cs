using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trigger : MonoBehaviour
{
    public TextMeshProUGUI ActionText;
   


    void OnTriggerExit(Collider other)
    {
        StartCoroutine(DeleteCoroutine());

    }

    IEnumerator DeleteCoroutine()

    {
        ActionText.text = "Dikkatli ol �ok ak�ll� de�iller ama sana zarar verebilirler!";
        yield return new WaitForSeconds(3f);
        ActionText.text = "";
        Destroy(this.gameObject);
    }


}
