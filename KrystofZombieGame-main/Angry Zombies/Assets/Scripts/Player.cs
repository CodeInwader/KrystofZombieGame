using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;

    public Animator Animator;

    public int playerLives = 90;

    bool animationCanPlay;

    public int lives;

    public Collider colider;

    public Transform hracTransform;

    public GameObject player;

    public Camera camera;

    bool dead = false;
    bool dieAgain = true;

    public static bool secondGunCollected = false;
    public static bool thirdguncollected = false;

    public float rotation;

    public score sss;

    public Text liveText;

    public CharacterController controller;

    public bool playerDeadAgain = true;
    void Start()
    {
        
        Cursor.visible = false;

        Settinghs settings = GetComponent<Settinghs>();
       
        
    }
    //Colecting guns and medkit

    private void OnTriggerEnter(Collider other)
    {


        Debug.Log("coliding");
        if (other.tag == "Gun2")
        {
            Debug.Log("im in");
            secondGunCollected = true;
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "Gun3")
        {
            thirdguncollected = true;
            other.gameObject.SetActive(false);
        }else if (other.tag == "Medkit")
        {
            if (playerLives < 90)
            {
                if (playerLives + 30 > 90)
                {
                    playerLives = 90;
                }
                else if (playerLives + 30 < 90)
                {
                    playerLives = playerLives + 30;
                }
            }
            other.gameObject.SetActive(false);
        }

    }

    
    // Update is called once per frame
    void Update()
    {
        liveText.text = "HP : " + playerLives.ToString();



        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = Vector3.right * x + Vector3.forward * y;


        Vector3 result = Vector3.forward * 5;
        result = Quaternion.Euler(0, rotation, 0) * result;


        controller.Move(move * speed * Time.deltaTime);

        

        //Moving, rotating player
        if (dead == false)
        {

            Vector3 poziceHraceNaObrazovce = camera.WorldToScreenPoint(hracTransform.position);
            Vector3 poziceMysiNaObrazovce = Input.mousePosition;

            Vector3 SmerKMysi = poziceMysiNaObrazovce - poziceHraceNaObrazovce;
            Vector3 FinalniVektor = new Vector3(SmerKMysi.x, 0, SmerKMysi.y);

            hracTransform.rotation = Quaternion.LookRotation(FinalniVektor);



        }

        float angle = player.transform.eulerAngles.y;

       
        
            int keysDown = 0;
            if (Input.GetKey(KeyCode.W))
                keysDown++;
            if (Input.GetKey(KeyCode.A))
                keysDown++;
            if (Input.GetKey(KeyCode.S))
                keysDown++;
            if (Input.GetKey(KeyCode.D))
                keysDown++;

            switch (keysDown)
            {
                case 1:
                    OnOneKeyPress();
                    break;

                case 2:
                    OnTwoKeyPress();
                    break;

            }


        keysDown = 0;
        

        void OnTwoKeyPress()
        {
            


            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D) && dead == false) // W D y > 0 && y < 2 && x > -2 && x < 0 Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)
            {
                if (angle > 25 && angle < 65)
                {
                    Animator.Play("RunForward");
                }
                else if (angle > 205 && angle < 245)
                {
                    Animator.Play("RunBackward");
                }
                else if (angle > 115 && angle < 155)
                {
                    Animator.Play("RunLeft");
                }
                else if (angle > 295 && angle < 335)
                {
                    Animator.Play("RunRight");
                }
                else if (angle > 65 && angle < 115)
                {
                    Animator.Play("RunForwardLeft");
                }
                else if (angle > 335 && angle < 361 || angle > 0.1 && angle < 26)
                {
                    Animator.Play("RunForwardRight");
                }
                else if (angle > 155 && angle < 205)
                {
                    Animator.Play("RunBackwardLeft");
                }
                else if (angle > 245 && angle < 295)
                {
                    Animator.Play("RunBackwardRight");
                }


            }

            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A) && dead == false) // W A y > 0 && y < 2 && x > 0 && x < 2 Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A)
            {
                if (angle > 294 && angle < 336)
                {
                    Animator.Play("RunForward");
                }
                else if (angle > 335 && angle < 361 || angle > 0.1 && angle < 25)
                {
                    Animator.Play("RunForwardLeft");
                }
                else if (angle > 115 && angle < 155)
                {
                    Animator.Play("RunBackward");
                }
                else if (angle > 245 && angle < 295)
                {
                    Animator.Play("RunForwardRight");
                }
                else if (angle > 25 && angle < 65)
                {
                    Animator.Play("RunLeft");
                }
                else if (angle > 205 && angle < 245)
                {
                    Animator.Play("RunRight");
                }
                else if (angle > 155 && angle < 205)
                {
                    Animator.Play("RunBackwardRight");
                }
                else if (angle > 65 && angle < 115)
                {
                    Animator.Play("RunBackwardLeft");
                }


            }

            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A) && dead == false) // S A y > -2 && y < 0 && x > 0 && x < 2 Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)
            {
                if (angle > 205 && angle < 245)
                {
                    Animator.Play("RunForward");
                }
                else if (angle > 245 && angle < 295)
                {
                    Animator.Play("RunForwardLeft");
                }
                else if (angle > 25 && angle < 65)
                {
                    Animator.Play("RunBackward");
                }
                else if (angle > 155 && angle < 205)
                {
                    Animator.Play("RunForwardRight");
                }
                else if (angle > 295 && angle < 336)
                {
                    Animator.Play("RunLeft");
                }
                else if (angle > 115 && angle < 155)
                {
                    Animator.Play("RunRight");
                }
                else if (angle > 335 && angle < 361 || angle > 0.1 && angle < 25)
                {
                    Animator.Play("RunBackwardLeft");
                }
                else if (angle > 65 && angle < 115)
                {
                    Animator.Play("RunBackwardRight");
                }


            }

            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D) && dead == false) // S D y > -2 && y < 0 && x > -2 && x < 0 Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D)
            {
                if (angle > 115 && angle < 155)
                {
                    Animator.Play("RunForward");
                }
                else if (angle > 155 && angle < 205)
                {
                    Animator.Play("RunForwardLeft");
                }
                else if (angle > 295 && angle < 335)
                {
                    Animator.Play("RunBackward");
                }
                else if (angle > 65 && angle < 115)
                {
                    Animator.Play("RunForwardRight");
                }
                else if (angle > 205 && angle < 245)
                {
                    Animator.Play("RunLeft");
                }
                else if (angle > 245 && angle < 295)
                {
                    Animator.Play("RunBackwardLeft");
                }
                else if (angle > 335 && angle < 361 || angle > 0.1 && angle < 25)
                {
                    Animator.Play("RunBackwardRight");
                }
                else if (angle > 25 && angle < 65)
                {
                    Animator.Play("RunRight");
                }


            }

        }

        void OnOneKeyPress()
        {
            



            if (Input.GetKey(KeyCode.W) && dead == false)//y > 0 && y < 2 && x < 1 && x > -1 
            {

                if (angle > 339 && angle < 361 || angle > 0.1 && angle < 20)
                {

                    Animator.Play("RunForward");

                }
                else if (angle > 20 && angle < 70)
                {
                    Animator.Play("RunForwardLeft");

                }
                else if (angle > 110 && angle < 160)
                {
                    Animator.Play("RunBackwardLeft");
                }
                else if (angle > 159 && angle < 200)
                {
                    Animator.Play("RunBackward");

                }
                else if (angle > 290 && angle < 340)
                {
                    Animator.Play("RunForwardRight");

                }
                else if (angle > 70 && angle < 110)
                {
                    Animator.Play("RunLeft");
                }
                else if (angle > 250 && angle < 290)
                {
                    Animator.Play("RunRight");
                }
                else if (angle > 200 && angle < 250)
                {
                    Animator.Play("RunBackwardRight");
                }

            }




            if (Input.GetKey(KeyCode.S) && dead == false)//y > -2 && y < 0 && x < 1 && x > -1 Input.GetKey(KeyCode.S)
            {
                if (angle > 339 && angle < 361 || angle > 0.1 && angle < 20)
                {
                    Animator.Play("RunBackward");
                }
                else if (angle > 160 && angle < 200)
                {
                    Animator.Play("RunForward");
                }
                else if (angle > 20 && angle < 70)
                {
                    Animator.Play("RunBackwardRight");
                }
                else if (angle > 70 && angle < 110)
                {
                    Animator.Play("RunRight");
                }
                else if (angle > 110 && angle < 160)
                {
                    Animator.Play("RunForwardRight");
                }
                else if (angle > 200 && angle < 250)
                {
                    Animator.Play("RunForwardLeft");
                }
                else if (angle > 250 && angle < 290)
                {
                    Animator.Play("RunLeft");
                }
                else if (angle > 290 && angle < 340)
                {
                    Animator.Play("RunBackwardLeft");
                }


            }

            if (Input.GetKey(KeyCode.A) && dead == false)//x > 0 && x < 2 && y < 1 && y > -1 
            {
                if (angle > 250 && angle < 290)
                {
                    Animator.Play("RunForward");
                }
                else if (angle > 70 && angle < 110)
                {
                    Animator.Play("RunBackward");
                }
                else if (angle > 339 && angle < 361 || angle > 0.1 && angle < 20)
                {
                    Animator.Play("RunLeft");
                }
                else if (angle > 160 && angle < 200)
                {
                    Animator.Play("RunRight");
                }
                else if (angle > 290 && angle < 340)
                {
                    Animator.Play("RunForwardLeft");
                }
                else if (angle > 200 && angle < 250)
                {
                    Animator.Play("RunForwardRight");
                }
                else if (angle > 110 && angle < 160)
                {
                    Animator.Play("RunBackwardLeft");
                }
                else if (angle > 20 && angle < 70)
                {
                    Animator.Play("RunBackwardRight");
                }


            }

            if (Input.GetKey(KeyCode.D) && dead == false) //x > - 2 && x < 0 && y < 1 && y > -1 Input.GetKey(KeyCode.D)
            {
                if (angle > 70 && angle < 110)
                {
                    Animator.Play("RunForward");
                }
                else if (angle > 110 && angle < 160)
                {
                    Animator.Play("RunForwardLeft");
                }
                else if (angle > 250 && angle < 290)
                {
                    Animator.Play("RunBackward");
                }
                else if (angle > 20 && angle < 70)
                {
                    Animator.Play("RunForwardRight");
                }
                else if (angle > 200 && angle < 250)
                {
                    Animator.Play("RunBackwardLeft");
                }
                else if (angle > 290 && angle < 340)
                {
                    Animator.Play("RunBackwardRight");
                }
                else if (angle > 339 && angle < 361 || angle > 0.1 && angle < 20)
                {
                    Animator.Play("RunRight");
                }
                else if (angle > 160 && angle < 200)
                {
                    Animator.Play("RunLeft");
                }


            }

        }

        if (dieAgain == true && playerLives == 0)
        {
            dead = true;
            speed = 0;
            Animator.Play("Dying ");
            dieAgain = false;
        }
        

    }


   
    
}
