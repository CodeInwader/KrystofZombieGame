using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 15f;

    public Animator Animator;

    public Transform hracTransform;

    public Camera camera;

    public CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 poziceHraceNaObrazovce = camera.WorldToScreenPoint(hracTransform.position);
        Vector3 poziceMysiNaObrazovce = Input.mousePosition;

        Vector3 SmerKMysi = poziceMysiNaObrazovce - poziceHraceNaObrazovce;
        Vector3 FinalniVektor = new Vector3(SmerKMysi.x, 0, SmerKMysi.y);

        hracTransform.rotation = Quaternion.LookRotation(FinalniVektor);



        float x = Input.GetAxis("Horizontal");
         float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;

        controller.Move(move * speed * Time.deltaTime);


        if (Input.GetKey(KeyCode.W))
        {
            Animator.Play("RunForward");

        }else if (Input.GetKey(KeyCode.S))
        {
            Animator.Play("RunBackward");
        }
    }
}
