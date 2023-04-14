using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitSignTrigger : MonoBehaviour
{
    [SerializeField]
    private KeyPickUp keyPickUp = null;
    [SerializeField] private GameObject exitSign;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("player"))
        {
            if (keyPickUp.haveKey)
            {
                exitSign.SetActive(true);
                Destroy(this.gameObject);
            }
        }


    }
}
