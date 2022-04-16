using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
 

[System.Serializable]
public class GunInformation
{
    public Transform gunTransform;
    public GameObject gunObject;
    public ParticleSystem muzzelFlash;
    public AudioSource shootSound;
    public int ammoInt;
    public string nameOfGun;
    public float reloadTime;
    public float time, waitTime;
    public bool gunisSelected;


}


public class Gun : MonoBehaviour
{
    public GunInformation gun;

    public List<GunInformation> guninformation;

   public Player livesOfPlayer;

    public int numberofdeadzombie = 0;

    public GameObject impactefect;

    public Transform shootPoint;

    public Text Ammo, HP, NameOfGun;

    public int AmmoIntText;
    public static int HPInt = 90;
    public string NameOfGunText;
    public float reloadTime;


    public int selectedGun;
    

    bool isReloading;
    private void Start()
    {
        selectedGun = 0;

        guninformation[selectedGun].gunisSelected = true;
        guninformation[selectedGun].muzzelFlash.Stop();
        guninformation[1].muzzelFlash.Stop();
        guninformation[2].muzzelFlash.Stop();

       guninformation[selectedGun].gunObject.SetActive(true);
       guninformation[1].gunObject.SetActive(false);
       guninformation[2].gunObject.SetActive(false);

        

        NameOfGunText = guninformation[0].nameOfGun;
        guninformation[0].ammoInt = 60;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedGun = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && Player.secondGunCollected == true)
        {
            selectedGun = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && Player.thirdguncollected == true)
        {
            selectedGun = 2;
        }


        //Dropy

       

        //shooting

        NameOfGun.text = guninformation[selectedGun].nameOfGun;
        Ammo.text = guninformation[selectedGun].ammoInt.ToString();

        if (selectedGun == 0)
        {
            
            guninformation[0].gunisSelected = true;
            guninformation[1].gunisSelected = false;
            guninformation[2].gunisSelected = false;

            guninformation[0].gunObject.SetActive(true);
            guninformation[1].gunObject.SetActive(false);
            guninformation[2].gunObject.SetActive(false);

            reloadTime = 3;
        }
        else if (selectedGun == 1)
        {
           
            guninformation[0].gunisSelected = false;
            guninformation[1].gunisSelected = true;
            guninformation[2].gunisSelected = false;

            guninformation[0].gunObject.SetActive(false);
            guninformation[1].gunObject.SetActive(true);
            guninformation[2].gunObject.SetActive(false);

            reloadTime = 3;
        }
        else if (selectedGun == 2)
        {
            
            guninformation[0].gunisSelected = false;
            guninformation[1].gunisSelected = false;
            guninformation[2].gunisSelected = true;

            guninformation[0].gunObject.SetActive(false);
            guninformation[1].gunObject.SetActive(false);
            guninformation[2].gunObject.SetActive(true);
            reloadTime = 5;
        }
       


        if (Input.GetKey(KeyCode.Mouse0) && guninformation[selectedGun].time < Time.time && guninformation[selectedGun].gunisSelected == true)
        {
           if(selectedGun == 2)
            {
                guninformation[2].muzzelFlash.Emit(100);
            }
            else
            {
                if (guninformation[selectedGun].muzzelFlash.isStopped/* && time1 < Time.time*/)
                {
                    guninformation[selectedGun].muzzelFlash.Play();
                }
            }

           

           guninformation[selectedGun].time = Time.time + guninformation[selectedGun].waitTime;
            Shoot();
            
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
           guninformation[selectedGun].muzzelFlash.Stop();       
        }
        
        
        if (livesOfPlayer.playerLives < 1)
        {
            guninformation[selectedGun].gunObject.SetActive(false);
            
        }

        if (guninformation[selectedGun].ammoInt <= 0)
        {
            switch (selectedGun)
            {
                case 0:
                    guninformation[selectedGun].ammoInt = 60;
                    break;

                case 1:
                    guninformation[selectedGun].ammoInt = 90;
                    break;

                case 2:
                    guninformation[selectedGun].ammoInt = 5;
                    break;
            }
        }


    }


    void Shoot()
    {
        RaycastHit hit;

        guninformation[selectedGun].shootSound.Play();

        guninformation[selectedGun].ammoInt--;
       

        if (Physics.Raycast(shootPoint.transform.position, shootPoint.transform.forward, out hit /*, range*/))
        {
            if (hit.transform.tag == "Zombie")
            {
                Zombie hitZombie = hit.transform.GetComponent<Zombie>();
                Zombie zombieCollider = hit.collider.GetComponent<Zombie>();
        
              hitZombie.livesOfZombie = hitZombie.livesOfZombie - 1;
                

                
               
            }

            Instantiate(impactefect, hit.point, Quaternion.LookRotation(hit.normal));
            
           
        }
        
    }
    
    
    IEnumerator Reload()
    {
        yield return new WaitForSeconds(reloadTime);
    }
}
