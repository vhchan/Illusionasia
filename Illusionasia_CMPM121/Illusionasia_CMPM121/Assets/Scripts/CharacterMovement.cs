using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public static bool winPegasusLevel = false;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;
    bool crouch = false;

    private Vector3 start;

    public static int lightning = 0;
    public static int thunder = 0;

    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            winPegasusLevel = true;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Vector3 pos = new Vector3(-14, 40, -1);
            transform.position = pos;
        }
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } 
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            transform.position = start;
        }
        else if (collision.gameObject.tag == "Lightning")
        {
            lightning++;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Thunder")
        {
            thunder++;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Finish")
        {
            if (lightning == 1 && thunder == 1)
            {
                Debug.Log("Yay you done");
                Destroy(collision.gameObject);
                winPegasusLevel = true;


            }
        }
    }
}
