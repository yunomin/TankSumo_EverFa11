using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed;
    public GameObject thePlayer;
    public bool isMoving;
    public float hMove;
    public float viewAxisH;
    public float viewAxisV;
    public float vMove;
    public float mass = -0.9f;
    public Rigidbody rb;
    public float thrust;
    public float boostThrust;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = new Vector3(0f, mass, 0f);
        moveSpeed = 1f;
        rb = GetComponent<Rigidbody>();
        boostThrust = 2000;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            isMoving = true;

            if (Input.GetButton("Vertical"))
            {
                thrust = Time.deltaTime * 1555 * Input.GetAxis("Vertical");
                rb.AddForce(transform.forward * thrust );
            }
            if (Input.GetButton("Horizontal"))
            {
                thrust = Time.deltaTime * 5000 * Input.GetAxis("Horizontal");
                rb.AddTorque(transform.up*thrust);
            }
            

        }
        if (Input.GetKeyDown("space"))
        {
            
            rb.AddForce(transform.forward * boostThrust);
            print("Boosting!");

        }

        else
        {
            thrust = 0;
        }

        //This section is for non physics based movement. It works, but is buggy.
        /*
           if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
           {

               isMoving = true;
               if (Input.GetButton("Horizontal"))
               {
                   viewAxisH = Input.GetAxis("Horizontal");
                   hMove = Input.GetAxis("Horizontal") * Mathf.Abs(Time.deltaTime) * 150f;
                   thePlayer.transform.Rotate(0, hMove, 0);
               }
               if (Input.GetButton("Vertical"))
               {
                   viewAxisV = Input.GetAxis("Vertical");
                   vMove = Input.GetAxis("Vertical") * Mathf.Abs(Time.deltaTime) * 150f;
                   thePlayer.transform.Translate(0, 0, vMove);
               }
                  // hMove = 0;
              // vMove = 0;

           }

           else
           {
               isMoving = false;
               hMove = 0;
               vMove = 0;
           }*/


    }
}
