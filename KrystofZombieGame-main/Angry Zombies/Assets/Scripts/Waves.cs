﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour
{

    public GameObject Zombie1;

    public GameObject boss;

    public Zombie lives;

    public List<GameObject> spawnPoints;

    

    public ObjectPooler objectPooler;

    public bool wave2CanStartTEST1 = true;
    public bool wave3CanStartTEST1 = true;
    public bool wave4CanStartTEST1 = true;
    public bool wave5CanStartTEST1 = true;

    public int currentWave = 1;
    int zombiesToSpawn;

    ObjectPooler objectt;

    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;

    GameObject zombiObject;

    // Start is called before the first frame update
    void Start()
    {
       
        Wave();
    }



    void Wave()
    {
        zombiesToSpawn = currentWave * 4;

        for (int i = 0; i <= zombiesToSpawn; i++)
        {
           
            GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Count)];

             zombiObject = ObjectPooler.Sharedinstance.GetPooledObject();

            if(zombiObject != null)
            {
                zombiObject.transform.position = spawnPoint.transform.position;
                zombiObject.transform.rotation = spawnPoint.transform.rotation;
                zombiObject.SetActive(true);
            }
        }

        currentWave++;


    }

   

    private void Update()
    {
        if (zombiesToSpawn == Zombie.numberOfDeadZombie)
        {
            Zombie.numberOfDeadZombie = 0;
            Wave();
        }
    }


}
