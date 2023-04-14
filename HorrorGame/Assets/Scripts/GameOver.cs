using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private HealthController healthController = null;
    [SerializeField] AudioSource hurt;
  
    void Update()
    {
        if(healthController.currentPlayerHealth < 0) {
            AudioSource.DontDestroyOnLoad(this.hurt);
            SceneManager.LoadScene("gameOver");}
    }
}
