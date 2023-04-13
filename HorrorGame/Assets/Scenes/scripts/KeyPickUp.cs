using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPickUp : MonoBehaviour
{
    [HideInInspector]
    public bool haveKey = false;
    public GameObject exitDoor;
    [SerializeField] public Image keyImage=null;
    [SerializeField] private GameObject keyArrow;
    public AudioSource KeySound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (haveKey)
        {
            
            keyImage.enabled = true;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("key")){

            if (!KeySound.isPlaying)
            {
                KeySound.Play();
            }
        
            Destroy(other.gameObject);
            haveKey = true;
            keyArrow.SetActive(false);
        }
        if (other.gameObject.tag.Equals("exit")&& haveKey)
        {
            exitDoor.GetComponent<Animator>().SetBool("hasKey", haveKey);
        }
    }
}
