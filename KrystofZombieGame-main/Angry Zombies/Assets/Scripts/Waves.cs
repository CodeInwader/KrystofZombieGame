using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour
{

    public GameObject Zombie1;

    public GameObject boss;

  public  Zombie lives;

    public bool wave2CanStartTEST1 = true;
    public bool wave3CanStartTEST1 = true;
    public bool wave4CanStartTEST1 = true;
    public bool wave5CanStartTEST1 = true;
    


    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;

    // Start is called before the first frame update
    void Start()
    {
        Wawe1();
    }

    // Update is called once per frame
    void Update()
    {
       

        switch (Zombie.numberOfDeadZombie)
        {
            case 3:
                Debug.Log(wave2CanStartTEST1);
                if (wave2CanStartTEST1)
                {
                    Wawe2();
                     
                }
                break;

            case 7:

                if (wave3CanStartTEST1)
                {
                    Wawe3();
                   
                }
                break;

            case 12:
                if (wave4CanStartTEST1)
                {
                    StartCoroutine(Wawe4());
                    
                }
                break;

            case 24:
                if (wave5CanStartTEST1)
                {
                    StartCoroutine(Wawe5());
                    
                }
                break;

            case 42:
                Boss();
           
                break;

        }
    }

    void Wawe1()
    {
       

        Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
        Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
        Instantiate(Zombie1, spawnPoint3.position, spawnPoint1.rotation);

    }

    void Wawe2()
    {
       
        if (wave2CanStartTEST1)
        {
           

            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint3.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint3.position, spawnPoint1.rotation);
            wave2CanStartTEST1 = false;
            
        }

    }

    void Wawe3()
    {
       
        if (wave3CanStartTEST1)
        {
            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint3.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint3.position, spawnPoint1.rotation);
            wave3CanStartTEST1 = false;
        }
       

    }

    IEnumerator Wawe4()
    {
        if (wave4CanStartTEST1)
        {
            wave4CanStartTEST1 = false;
            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint3.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint3.position, spawnPoint1.rotation);

            yield return new WaitForSeconds(3);

            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint2.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint2.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint2.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint2.position, spawnPoint1.rotation);
            
        }
       


    }

    IEnumerator Wawe5()
    {
        if (wave5CanStartTEST1)
        {
            wave5CanStartTEST1 = false;
            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint3.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint3.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint1.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint1.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint2.position, spawnPoint1.rotation);

            yield return new WaitForSeconds(3);

            Instantiate(Zombie1, spawnPoint1.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint1.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint2.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint2.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint2.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint3.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint3.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            Instantiate(Zombie1, spawnPoint4.position, spawnPoint1.rotation);
            
        }
           

    }

    void Boss()
    {
        Instantiate(boss, spawnPoint1.position, spawnPoint1.rotation);
    }
}
