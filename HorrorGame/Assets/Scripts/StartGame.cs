using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    
    public void StartTheGame()
    {
    
        GetComponent<AudioSource>().Play();
        GameObject.DontDestroyOnLoad(this.gameObject);
        SceneManager.LoadScene("final");
    }
}