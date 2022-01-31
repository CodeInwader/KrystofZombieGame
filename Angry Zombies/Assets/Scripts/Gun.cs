using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class Gun : MonoBehaviour
{

    public Transform gun;
    public float range = 100f;

    public GameObject gunObject1;
   public Player livesOfPlayer;

    

    public ParticleSystem muzzleFlash1;
    public GameObject impactefect;

    public AudioSource shoot1;

    public float time, waitingTime = 0.2f;

    private void Start()
    {
        muzzleFlash1.Stop();
    }

    // Update is called once per frame
    void Update()
    {

       


        if (Input.GetKey(KeyCode.Mouse0) && time < Time.time)
        {
           

            if (muzzleFlash1.isStopped && time < Time.time)
            {
                muzzleFlash1.Play();
            }

            time = Time.time + waitingTime;
            Shoot();
            
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            muzzleFlash1.Stop();
        }

        
        



        if (livesOfPlayer.playerLives < 1)
        {
            gunObject1.SetActive(false);
        }

       
    }


    void Shoot()
    {
        RaycastHit hit;

        shoot1.Play();

       

        if (Physics.Raycast(gun.transform.position, gun.transform.forward * -1, out hit /*, range*/))
        {
            if (hit.transform.tag == "Zombie")
            {
                Zombie hitZombie = hit.transform.GetComponent<Zombie>();
                Zombie zombieCollider = hit.collider.GetComponent<Zombie>();
        
              hitZombie.livesOfZombie = hitZombie.livesOfZombie - 1;
                Debug.Log(hit.transform);

                if (hitZombie.livesOfZombie < 1)
                {
                    zombieCollider.zombieColider.enabled = false;
                }
               
            }


            

            Instantiate(impactefect, hit.point, Quaternion.LookRotation(hit.normal));
           
        }
        
    }

    


    
    
}
