using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public static int livesOfZombie = 1;

    public GameObject zombie;

    public Animator ZombieAnimator;

<<<<<<< HEAD
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

=======
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (livesOfZombie == 0)
        {
>>>>>>> parent of 278b0c0 (Week 2)
        
            Dead();
        }
    }

    void Dead()
    {

        ZombieAnimator.Play("DieAnimation");
        
    }

<<<<<<< HEAD
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
        
=======

    void Run()
    {
        ZombieAnimator.Play("RunAnimation");
>>>>>>> parent of 278b0c0 (Week 2)
    }

    void GoToPlayer()
    {

    }
<<<<<<< HEAD

    public void DamageZombie()
    {
        livesOfZombie = livesOfZombie - 1;
        
    }
=======
>>>>>>> parent of 278b0c0 (Week 2)
}
