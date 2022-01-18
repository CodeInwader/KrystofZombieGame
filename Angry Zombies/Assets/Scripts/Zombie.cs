using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public static int livesOfZombie = 1;

    public GameObject zombie;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (livesOfZombie == 0)
        {
        
            Dead();
        }
    }

    void Dead()
    {
        Destroy(zombie);
        
    }
}
