using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{

    public float currentPlayerHealth = 100.0f;
    [SerializeField] private int regenRate = 1;
    private bool canRegen = false;
    [SerializeField]
    private float healCooldown = 3.0f;
    [SerializeField]
    private float maxHealCooldown = 3.0f;
    [SerializeField]
    private bool startCooldown = false;
    [SerializeField] private float maxPlayerHealth = 100.0f;
    [SerializeField] private Image bloodSplatter = null;
    [SerializeField] private Image hurtImage = null;
    [SerializeField] private float hurtTimer = 0.1f;
    public Image lifeBar = null;

    

    void UpdateHealth()
    {
        Color bloodAlpha = bloodSplatter.color;
        bloodAlpha.a = 1 - (currentPlayerHealth / maxPlayerHealth);
        bloodSplatter.color = bloodAlpha;
        
    }
    IEnumerator HurtFlash()
    {
        hurtImage.enabled = true;
      
        yield return new WaitForSeconds(hurtTimer);
        hurtImage.enabled = false;
    }
    public void TakeDamage()
    {
        if (currentPlayerHealth >= 0)
        {
            canRegen = false;
            StartCoroutine(HurtFlash());
            UpdateHealth();
            healCooldown = maxHealCooldown;
            startCooldown = true;
        }
    }
    void Update()
    {
        if (startCooldown)
        {
            healCooldown -= Time.deltaTime;
            if (healCooldown <= 0)
            {
                canRegen = true;
                startCooldown = false;
            }
        }
        if (canRegen)
        {
            if(currentPlayerHealth<=maxPlayerHealth - 0.01)
            {
                currentPlayerHealth += Time.deltaTime * regenRate;
                lifeBar.fillAmount += Time.deltaTime * regenRate*0.01f; ;
                UpdateHealth();
            }
            else
            {
                currentPlayerHealth = maxPlayerHealth;
                healCooldown = maxHealCooldown;
                lifeBar.fillAmount = 1f;
                canRegen = false;
            }
        }
    }
}
