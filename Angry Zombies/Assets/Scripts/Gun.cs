using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public Transform gun;
    public float range = 100f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Shoot();
        }
    }


    void Shoot()
    {
        RaycastHit hit;


        if (Physics.Raycast(gun.transform.position, gun.transform.forward * -1, out hit, range))
        {
            if (hit.transform.tag == "Zombie")
            {
              Zombie.livesOfZombie = Zombie.livesOfZombie - 1;
                Debug.Log(hit.transform);

            }
            
           
        }
        
    }
}
