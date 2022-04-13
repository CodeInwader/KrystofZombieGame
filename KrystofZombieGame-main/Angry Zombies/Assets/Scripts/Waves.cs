using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public  class DataForBackSettings
{
    public static bool backFromMenu;
    
}



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

    public int currentWave;
    public static int zombiesToSpawn;

    ObjectPooler objectt;

    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;

    GameObject zombiObject;

    private void Start()
    {
        currentWave = 1;
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

        /*
        if (score.playerScore == 5200)
        {

        }
        */
    }

    
}
