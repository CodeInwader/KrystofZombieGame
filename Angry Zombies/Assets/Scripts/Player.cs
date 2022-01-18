using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 15f;

    public Animator Animator;

    public int playerLives = 3;

    public Transform hracTransform;

    public Camera camera;

    bool dead = false;
    bool dieAgain = true;

    public CharacterController controller;
    
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        



        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;

        controller.Move(move * speed * Time.deltaTime);


        if (dead == false)
        {

            Vector3 poziceHraceNaObrazovce = camera.WorldToScreenPoint(hracTransform.position);
            Vector3 poziceMysiNaObrazovce = Input.mousePosition;

            Vector3 SmerKMysi = poziceMysiNaObrazovce - poziceHraceNaObrazovce;
            Vector3 FinalniVektor = new Vector3(SmerKMysi.x, 0, SmerKMysi.y);

            hracTransform.rotation = Quaternion.LookRotation(FinalniVektor);

          if (Input.GetKey(KeyCode.W))
          {
            Animator.Play("RunForward");

          } else if (Input.GetKey(KeyCode.S))
          {
            Animator.Play("RunBackward");

          } else if (Input.GetKey(KeyCode.A))
          {
            Animator.Play("RunLeft");

          }else if (Input.GetKey(KeyCode.D))
          {
            Animator.Play("RunRight");

          }else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
          {
            Animator.Play("RunForwardLeft");

          }else if (Input.GetKey(KeyCode.W)&& Input.GetKey(KeyCode.D))
          {
            Animator.Play("RunForwardRight");

          }else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)) 
          {
            Animator.Play("RunBackwardLeft");

          }else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
          {
            Animator.Play("RunBackwardRight");
          }
        

        }
        

        if (dieAgain == true && playerLives == 0)
        {
            dead = true;
            speed = 0;
            Animator.Play("Dying");
            dieAgain = false;
        }
        

        
        


        
    }
}
