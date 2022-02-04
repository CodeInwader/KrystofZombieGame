using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WavesOfZombies : MonoBehaviour
{
    public GameObject zombie1;

    public List<GameObject> WaveList = new List<GameObject>();
   

    public Transform spawnpoint1;
    public Transform spawnpoint2;
    public Transform spawnpoint3;
    public Transform spawnpoint4;

    public int WaveStat;

    bool WaveCanBePlaid = false;

    public static int numberOfDeadZombie = 0;
    public int number;

    

    // Start is called before the first frame update
    void Start()
    {
        WaveStat = 1;

        WaveList.Add(zombie1);

    }
    
    // Update is called once per frame
    void Update()
    {
        number = numberOfDeadZombie;
        switch (WaveStat)
        {
            case 1:
                
                Wave1();
                break;

            case 2:
                WaveCanBePlaid = true;
                Wave2();
                break;

            case 3:
                WaveCanBePlaid = true;
                Wave3();
                break;

            case 4:
                WaveCanBePlaid = true;
                Wave4();
                break;

            case 5:
                WaveCanBePlaid = true;
                Wave5();
                break;

            case 6:
                WaveCanBePlaid = true;
                Wave6();
                break;

            case 7:
                WaveCanBePlaid = true;
                Wave7();
                break;

            case 8:
                WaveCanBePlaid = true;
                Wave8();
                break;

            case 9:
                WaveCanBePlaid = true;
                Wave9();
                break;

            case 10:
                WaveCanBePlaid = true;
                Wave10();
                break;
        }
        
    }
    void Wave1()
    {
        if(WaveCanBePlaid == true)
        {
            Instantiate(WaveList[0], spawnpoint1.transform.position, Quaternion.LookRotation(spawnpoint1.position));
            Instantiate(WaveList[0], spawnpoint1.transform.position, Quaternion.LookRotation(spawnpoint1.position));
            Instantiate(WaveList[0], spawnpoint2.transform.position, Quaternion.LookRotation(spawnpoint1.position));
            WaveCanBePlaid = false;

            if (numberOfDeadZombie > 3)
            {
               // WaveStat = 2;
                //WaveCanBePlaid = true;
            }
            
        }

        
       
    }

    void Wave2()
    {
        numberOfDeadZombie = 0;
        
        if (WaveCanBePlaid == true)
        {
            Debug.Log("Second Wave Started");
            Instantiate(WaveList[0], spawnpoint1.transform.position, Quaternion.LookRotation(spawnpoint1.position));
            Instantiate(WaveList[0], spawnpoint1.transform.position, Quaternion.LookRotation(spawnpoint1.position));
            Instantiate(WaveList[0], spawnpoint2.transform.position, Quaternion.LookRotation(spawnpoint1.position));
            Instantiate(WaveList[0], spawnpoint2.transform.position, Quaternion.LookRotation(spawnpoint1.position));
            WaveCanBePlaid = false;
        }

        if (numberOfDeadZombie >= 4)
        {
            //WaveStat = 3;
           // WaveCanBePlaid = true;
        }


    }

    void Wave3()
    {
        if (WaveCanBePlaid == true)
        {
            WaveCanBePlaid = false;
        }
    }

    void Wave4()
    {
        if (WaveCanBePlaid == true)
        {
            WaveCanBePlaid = false;
        }
    }

    void Wave5()
    {
        if (WaveCanBePlaid == true)
        {
            WaveCanBePlaid = false;
        }
    }

    void Wave6()
    {
        if (WaveCanBePlaid == true)
        {
            WaveCanBePlaid = false;
        }
    }

    void Wave7()
    {
        if (WaveCanBePlaid == true)
        {
            WaveCanBePlaid = false;
        }
    }

    void Wave8()
    {
        if (WaveCanBePlaid == true)
        {
            WaveCanBePlaid = false;
        }

    }

    void Wave9()
    {
        if (WaveCanBePlaid == true)
        {
            WaveCanBePlaid = false;
        }

    }

    void Wave10()
    {
        if (WaveCanBePlaid == true)
        {
            WaveCanBePlaid = false;
        }
    }
}
