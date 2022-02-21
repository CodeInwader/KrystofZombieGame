using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

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

    public GameObject gunObject2;
    public GameObject gunObject3;

    public static bool secondGunIsSpawned = false;
    public static bool thirdGunIsSpawned = false;

    public GameObject medkit;

    public static int numberOfDeadZombie = 0;

    

    bool againZombieDead = true;

    public AudioSource bite;

    public Rigidbody rb;

    public score sss;

    public bool playerDeadAgain = true;


    private void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
      

        if (  lives.playerLives < 1 && playerDeadAgain )
        {
            canFolow = false;


            Debug.Log("sdsd");
            //sss.EndOfPlay();
            playerDeadAgain = false;
        }


        if (againZombieDead == true && livesOfZombie < 1  )
        {
            

            ZombieAnimator.Play("DieAnimation");
            canFolow = false;
            numberOfDeadZombie++;
            againZombieDead = false;
            rb.constraints = RigidbodyConstraints.FreezeAll;

            //pricteni skore
           
            sss.AddScore();
            Debug.Log(sss.playerScore);

            //moznost spawnu zbrane nebo medkitu000
            int randomNumber = Random.Range(1, 3);

            if (randomNumber == 1)
            {
                int secondRandomNumber = Random.Range(1, 3);

                if (secondRandomNumber == 1)
                {
                    int thirdrRandomnumber = Random.Range(1, 3);

                    if (thirdrRandomnumber == 1 && secondGunIsSpawned == false)
                    {
                        Instantiate(gunObject2, Zombieobject.transform.position, Zombieobject.transform.rotation);
                        secondGunIsSpawned = true;
                    }
                    else if (thirdrRandomnumber == 2 && thirdGunIsSpawned == false)
                    {
                        Instantiate(gunObject3, Zombieobject.transform.position, Zombieobject.transform.rotation);
                        thirdGunIsSpawned = true;
                    }

                }
                else if (secondRandomNumber == 2)
                {
                    Instantiate(medkit, Zombieobject.transform.position, Zombieobject.transform.rotation);
                }
            }
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
            lives.playerLives = lives.playerLives - 30;
            canFolow = true;
            bite.Play();
        }

    }

    public void EndanimationEvent()
    {
        canFolow = true;
    }

}


    

