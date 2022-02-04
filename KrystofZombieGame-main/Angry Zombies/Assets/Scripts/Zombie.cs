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

    public GameObject Player;
    public GameObject Zombieobject;



    public AudioSource bite;


    // Update is called once per frame
    void Update()
    {
        if (lives.playerLives < 1)
        {
            canFolow = false;
        }


        if (livesOfZombie < 1)
        {
            ZombieAnimator.Play("DieAnimation");
            canFolow = false;
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


    

