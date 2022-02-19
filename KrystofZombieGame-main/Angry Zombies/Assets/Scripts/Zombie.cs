using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    public double livesOfZombie = 1;

    public Player lives;

    public Animator ZombieAnimator;

    public NavMeshAgent zombie;

    bool canFolow = true;
    public Transform playerTransform;

    public Collider colider;

    public Collider zombieColider;

    public GameObject Player;
    public GameObject Zombieobject;

    public static int numberOfDeadZombie = 0;

    bool againZombieDead = true;

    public AudioSource bite;

    public Rigidbody rb;


    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       

        if (lives.playerLives < 1)
        {
            canFolow = false;
        }


        if (againZombieDead == true && livesOfZombie < 1  )
        {
            ZombieAnimator.Play("DieAnimation");
            canFolow = false;
            numberOfDeadZombie++;
            againZombieDead = false;
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }

        Debug.Log(numberOfDeadZombie);

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

    public void PunchEvent()
    {
        float distance = Vector3.Distance(Player.transform.position, Zombieobject.transform.position);
        Debug.Log(distance);
        if (distance < 2)
        {
            lives.playerLives = lives.playerLives - 1;
            canFolow = true;
            bite.Play();
        }

    }

    public void EndanimationEvent()
    {
        canFolow = true;
    }

}


    

