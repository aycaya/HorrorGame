using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class TextController : MonoBehaviour
{
    public TextMeshPro ActionText= null;
    public void NewText()
    {
        ActionText = GetComponent<TextMeshPro>();
        ActionText.text = "";
    }

  
}
