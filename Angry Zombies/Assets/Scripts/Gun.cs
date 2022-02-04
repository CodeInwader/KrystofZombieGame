using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

<<<<<<< HEAD
    public Transform gun1;
    public GameObject gunObject1;
    public AudioSource shoot1;
    public ParticleSystem muzzleFlash1;

    public Transform gun2;
    public GameObject gunObject2;
    public AudioSource shoot2;
    public ParticleSystem muzzleFlash2;

    public Transform gun3;
    public GameObject gunObject3;
    public AudioSource shoot3;
    public ParticleSystem muzzleFlash3;

    public Player livesOfPlayer;

    public GameObject impactefect;


    int gunSelect = 1;


    public float time, waitingTime = 0.2f;

    public Zombie DamageZonmbie;

    private void Awake()
    {
        muzzleFlash1.Stop();
        muzzleFlash2.Stop();
        muzzleFlash3.Stop();
    }

    private void Start()
    {
        muzzleFlash1.Stop();
        muzzleFlash2.Stop();
        muzzleFlash3.Stop();


        gunSelect = 1;
    }
=======
    public Transform gun;
    public float range = 100f;

>>>>>>> parent of 278b0c0 (Week 2)

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        switch (gunSelect)
        {
            case 1:
                Gun1();
                Debug.Log("kkkkkkkkk ses");
                break;

            case 2:
                Gun2();
                break;

            case 3:
                Gun3();
                break;

        }
        
        void Gun1()
        {
            if (Input.GetKey(KeyCode.Mouse0) && time < Time.time)
            {
                RaycastHit hit;

                shoot1.Play();



                if (Physics.Raycast(gun1.transform.position, gun1.transform.forward * -1, out hit /*, range*/))
                {
                    Debug.Log(hit.transform);
                    if (hit.transform.tag == "Zombie")
                    {
                        Zombie hitZombie = hit.transform.GetComponent<Zombie>();
                        Zombie zombieCollider = hit.collider.GetComponent<Zombie>();



                        DamageZonmbie.DamageZombie();

                        Debug.Log(hit.transform);

                        if (hitZombie.livesOfZombie < 1)
                        {
                            zombieCollider.zombieColider.enabled = false;
                        }

                    }




                    Instantiate(impactefect, hit.point, Quaternion.LookRotation(hit.normal));

                }

                if (muzzleFlash1.isStopped && time < Time.time)
                {
                    muzzleFlash1.Play();
                }

                time = Time.time + waitingTime;
                Gun10();

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
       
        void Gun2()
        {
            if (Input.GetKey(KeyCode.Mouse0) && time < Time.time)
            {


                if (muzzleFlash1.isStopped && time < Time.time)
                {
                    muzzleFlash2.Play();
                }

                time = Time.time + waitingTime;
                Gun2();

            }
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                muzzleFlash2.Stop();
            }


            if (livesOfPlayer.playerLives < 1)
            {
                gunObject1.SetActive(false);
            }
        }

        void Gun3()
        {
            if (Input.GetKey(KeyCode.Mouse0) && time < Time.time)
            {


                if (muzzleFlash1.isStopped && time < Time.time)
                {
                    muzzleFlash3.Play();
                }

                time = Time.time + waitingTime;
                Gun3();

            }
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                muzzleFlash3.Stop();
            }


            if (livesOfPlayer.playerLives < 1)
            {
                gunObject1.SetActive(false);
            }
        }
       
=======
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Shoot();
        }
>>>>>>> parent of 278b0c0 (Week 2)
    }


    void Gun10()
    {
       
        
    }

    
    void Gun2()
    {
        RaycastHit hit;

<<<<<<< HEAD
        shoot2.Play();



        if (Physics.Raycast(gun2.transform.position, gun2.transform.forward * -1, out hit /*, range*/))
=======

        if (Physics.Raycast(gun.transform.position, gun.transform.forward * -1, out hit, range))
>>>>>>> parent of 278b0c0 (Week 2)
        {

            if (hit.transform.tag == "Zombie")
            {
<<<<<<< HEAD
                Zombie hitZombie = hit.transform.GetComponent<Zombie>();
                Zombie zombieCollider = hit.collider.GetComponent<Zombie>();

               

                DamageZonmbie.DamageZombie();

                Debug.Log(hit.transform);

                if (hitZombie.livesOfZombie < 1)
                {
                    zombieCollider.zombieColider.enabled = false;
                }

            }




            Instantiate(impactefect, hit.point, Quaternion.LookRotation(hit.normal));

=======
              Zombie.livesOfZombie = Zombie.livesOfZombie - 1;
                Debug.Log(hit.transform);

            }
            
           
>>>>>>> parent of 278b0c0 (Week 2)
        }

    }
<<<<<<< HEAD

    void Gun3()
    {
        RaycastHit hit;

        shoot3.Play();



        if (Physics.Raycast(gun3.transform.position, gun3.transform.forward * -1, out hit /*, range*/))
        {

            if (hit.transform.tag == "Zombie")
            {
                Zombie hitZombie = hit.transform.GetComponent<Zombie>();
                Zombie zombieCollider = hit.collider.GetComponent<Zombie>();



                DamageZonmbie.DamageZombie();

                Debug.Log(hit.transform);

                if (hitZombie.livesOfZombie < 1)
                {
                    zombieCollider.zombieColider.enabled = false;
                }

            }




            Instantiate(impactefect, hit.point, Quaternion.LookRotation(hit.normal));

        }
    }

=======
>>>>>>> parent of 278b0c0 (Week 2)
}
