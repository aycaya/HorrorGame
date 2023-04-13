using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class TextController : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshPro ActionText= null;
    public void NewText()
    {
        ActionText = GetComponent<TextMeshPro>();
        //TextMesh ActionText = (TextMesh)FindObjectOfType(typeof(TextMesh));
        ActionText.text = "";
    }

  
}
