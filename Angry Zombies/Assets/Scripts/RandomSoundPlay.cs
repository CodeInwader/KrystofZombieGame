using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSoundPlay : MonoBehaviour
{
    public float time, waitingTime = 0.2f;

    public List<AudioSource> Audio = new List<AudioSource>();

    public AudioSource moah1;
    public AudioSource moah2;
    public AudioSource moah3;
    public AudioSource moah4;

    void Start()
    {
        Audio.Add(moah1);
        Audio.Add(moah2);
        Audio.Add(moah3);
        Audio.Add(moah4);
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
                    Audio[0].Play();
                    break;

                case 2:
                    Audio[1].Play();
                    
                    break;

                case 3:
                    Audio[2].Play();
                    break;

                case 4:
                    Audio[3].Play();
                    break;
            }
        }
    }
}
