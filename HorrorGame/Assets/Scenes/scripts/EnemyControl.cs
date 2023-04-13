using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyControl : MonoBehaviour
{
    NavMeshAgent navAgent;
    Animator anim;
   
    public Transform player;
    [SerializeField]
    private float attackDamage = 10.0f;
    [SerializeField]
    private HealthController healthController = null;
    [SerializeField]
    private AudioClip zombieAttack = null;
    
    [SerializeField]
    private AudioSource zombieAudioSource;
    
    [SerializeField]
    float turnSpeed = 1f;
    public Image lifeBar = null;

 

    void Start()
    {
        anim = GetComponent<Animator>();
      
        navAgent = GetComponent<NavMeshAgent>();
  
    }


    void Update()
    {
       
        if (Vector3.Distance(transform.position, player.transform.position) < 6.15)
            {
            Vector3 direction = (player.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed);

            //transform.LookAt(player);
            navAgent.SetDestination(player.transform.position);
             }

       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("player"))
        {
            anim.SetBool("isClose", true);
            if (!zombieAudioSource.isPlaying)
            {
                zombieAudioSource.PlayOneShot(zombieAttack);
            }
            healthController.currentPlayerHealth -= attackDamage;
            lifeBar.fillAmount -= attackDamage * 0.01f;
            healthController.TakeDamage();
            
        }
      
   
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("player"))

        {
            anim.SetBool("isClose",false);

            
        }
    }
}
