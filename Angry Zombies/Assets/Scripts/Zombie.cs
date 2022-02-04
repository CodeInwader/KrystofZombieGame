using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    public int livesOfZombie = 1;

    public Player lives;

    public Animator ZombieAnimator;

    public NavMeshAgent zombie;
    bool canFolow = true;
    public Transform playerTransform;

    public Collider colider;

    public Collider zombieColider;

    bool canPunch;

    public AudioSource bite;

    public GameObject ZombieObject;
    public GameObject PlayerObject;

    public Player DamagePlayer;

    bool a = true;
   
    // Update is called once per frame
    void Update()
    {

        

       
        if (lives.playerLives < 1 )
        {
            canFolow = false;
            
        }

        
         
        if (livesOfZombie < 1)
        {
            ZombieAnimator.Play("DieAnimation");
            canFolow = false;
           // a = false;
           // WavesOfZombies.numberOfDeadZombie = WavesOfZombies.numberOfDeadZombie + 1;

        }

        

        if (canFolow == true)
        {
            ZombieAnimator.Play("RunAnimation");
            zombie.SetDestination(playerTransform.position);
        }

    }

    void OnTriggerStay(Collider colider)
    {
        if (colider.tag == "Player" && lives.playerLives > 0 && livesOfZombie > 0)
        {
            canFolow = false;
            ZombieAnimator.Play("Punch");


        }

        
    }

    private void OnTriggerEnter(Collider colider)
    {
        canPunch = true;
    }
    public void PunchEvent()
    {
        float distance = Vector3.Distance(PlayerObject.transform.position, ZombieObject.transform.position);

        if (distance < 2)
        {
            DamagePlayer.TakeDamagePlayer();
            canFolow = true;
            bite.Play();
        }
        
    }
    
    public void EndanimationEvent()
    {
        canFolow = true;
    }

    public void DamageZombie()
    {
        livesOfZombie = livesOfZombie - 1;
        
    }
}
