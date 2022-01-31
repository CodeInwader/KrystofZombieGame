using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSoundPlay : MonoBehaviour
{
    public float time, waitingTime = 0.2f;

    public AudioSource moah1;
    public AudioSource moah2;
    public AudioSource moah3;
    public AudioSource moah4;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (time < Time.time)
        {
            time = Time.time + waitingTime;

            int a = Random.Range(1, 5);

            switch (a)
            {
                case 1:
                    moah1.Play();
                    break;

                case 2:
                    moah2.Play();
                    break;

                case 3:
                    moah3.Play();
                    break;

                case 4:
                    moah4.Play();
                    break;
            }
        }
    }
}
