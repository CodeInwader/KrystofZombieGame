using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class GunTest : MonoBehaviour
{

    public Transform gun1;
    public Transform gun2;
    public Transform gun3;
    public float range = 100f;

    public GameObject gunObject1;
    public GameObject gunObject2;
    public GameObject gunObject3;


    public Player livesOfPlayer;

    public int numberofdeadzombie = 0;

    public ParticleSystem muzzleFlash1;
    public ParticleSystem muzzelFlash2;
    public ParticleSystem muzzelflash3;

    public GameObject impactefect;

    public AudioSource shoot1;
    public AudioSource shoot2;
    public AudioSource shoot3;

    public float time1, time2, time3, waitingTime1 = 0.2f, waitingTime2 = 0.5f, waitingTime3 = 1f;

    bool gun1IsSelected = false;
    bool gun2IsSelected = false;
    bool gun3IsSelected = false;

    public Text Ammo, HP, NameOfGun;

    public int AmmoInt;
    public static int HPInt = 90;
    public string NameOfGunString;
    public float reloadTime;

    public Guninfo gun;



    bool isReloading;
    private void Start()
    {
        gun1IsSelected = true;
        muzzleFlash1.Stop();
        muzzelFlash2.Stop();
        muzzelflash3.Stop();

        gunObject1.SetActive(true);
        gunObject2.SetActive(false);
        gunObject3.SetActive(false);



        NameOfGunString = "M4A1 Sopmod Variant";
        AmmoInt = 60;


    }

    // Update is called once per frame
    void Update()
    {
        //Dropy



        //shooting

        NameOfGun.text = NameOfGunString;
        Ammo.text = AmmoInt.ToString();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            NameOfGunString = "M4A1 Sopmod Variant";
            AmmoInt = 60;

            gun1IsSelected = true;
            gun2IsSelected = false;
            gun3IsSelected = false;

            gunObject1.SetActive(true);
            gunObject2.SetActive(false);
            gunObject3.SetActive(false);

            reloadTime = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && Player.secondGunCollected == true)
        {
            NameOfGunString = "UMP-45 Variant";
            AmmoInt = 90;

            gun1IsSelected = false;
            gun2IsSelected = true;
            gun3IsSelected = false;

            gunObject1.SetActive(false);
            gunObject2.SetActive(true);
            gunObject3.SetActive(false);

            reloadTime = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && Player.thirdguncollected == true)
        {
            NameOfGunString = "Shotgun Variant";
            AmmoInt = 1;

            gun1IsSelected = false;
            gun2IsSelected = false;
            gun3IsSelected = true;

            gunObject1.SetActive(false);
            gunObject2.SetActive(false);
            gunObject3.SetActive(true);
            reloadTime = 5;
        }



        if (Input.GetKey(KeyCode.Mouse0) && time1 < Time.time && gun1IsSelected == true)
        {


            if (muzzleFlash1.isStopped/* && time1 < Time.time*/)
            {
                muzzleFlash1.Play();
            }

            time1 = Time.time + waitingTime1;
            Shoot1();

        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            muzzleFlash1.Stop();
        }

        if (Input.GetKey(KeyCode.Mouse0) && time2 < Time.time && gun2IsSelected == true)
        {
            if (muzzelFlash2.isStopped /*&& time2 < Time.time*/)
            {
                muzzelFlash2.Play();
            }
            time2 = Time.time + waitingTime2;
            Shoot2();

        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            muzzelFlash2.Stop();
        }

        if (Input.GetKey(KeyCode.Mouse0) && time3 < Time.time && gun3IsSelected == true)
        {
            if (muzzelflash3.isStopped/* && time3 < Time.time*/)
            {
                muzzelflash3.Play();
            }
            time3 = Time.time + waitingTime3;
            Shoot3();
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            muzzelflash3.Stop();

        }


        if (livesOfPlayer.playerLives < 1)
        {
            gunObject1.SetActive(false);
            gunObject2.SetActive(false);
            gunObject3.SetActive(false);
        }


    }


    void Shoot1()
    {
        RaycastHit hit;

        shoot1.Play();

        AmmoInt--;


        if (Physics.Raycast(gun1.transform.position, gun1.transform.forward * -1, out hit /*, range*/))
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


            if (AmmoInt <= 0)
            {
                AmmoInt = 60;
            }

            Instantiate(impactefect, hit.point, Quaternion.LookRotation(hit.normal));

        }

    }

    void Shoot2()
    {
        RaycastHit hit;

        shoot2.Play();

        AmmoInt--;

        if (Physics.Raycast(gun2.transform.position, gun2.transform.forward, out hit /*, range*/))
        {
            if (hit.transform.tag == "Zombie")
            {
                Zombie hitZombie = hit.transform.GetComponent<Zombie>();
                Zombie zombieCollider = hit.collider.GetComponent<Zombie>();

                hitZombie.livesOfZombie = hitZombie.livesOfZombie - 0.5;
                Debug.Log(hit.transform);

                if (hitZombie.livesOfZombie < 1)
                {
                    zombieCollider.zombieColider.enabled = false;
                }

            }


            if (AmmoInt <= 0)
            {
                AmmoInt = 90;
            }


            Instantiate(impactefect, hit.point, Quaternion.LookRotation(hit.normal));

        }
    }

    void Shoot3()
    {
        RaycastHit hit;

        shoot3.Play();

        AmmoInt--;

        if (Physics.Raycast(gun3.transform.position, gun3.transform.right * -1, out hit /*, range*/))
        {

            if (hit.transform.tag == "Zombie")
            {
                Zombie hitZombie = hit.transform.GetComponent<Zombie>();
                Zombie zombieCollider = hit.collider.GetComponent<Zombie>();

                hitZombie.livesOfZombie = hitZombie.livesOfZombie - 3;
                Debug.Log(hit.transform);

                if (hitZombie.livesOfZombie < 1)
                {
                    zombieCollider.zombieColider.enabled = false;
                }

            }


            if (AmmoInt <= 0)
            {
                AmmoInt = 1;
            }


            Instantiate(impactefect, hit.point, Quaternion.LookRotation(hit.normal));

        }
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(reloadTime);
    }
}
