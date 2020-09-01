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
    public static float boostCapacity;
    public float boostCapacityMirror; // exists so I can see it live in the editor without needing to print it out.
    public bool boosting; // returns true if player is actively boosting
    public bool onGround; //returns true if player is on the ground.
    private Vector3 m_EulerAngleVelocity;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = new Vector3(0f, mass, 0f);
        moveSpeed = 1f;
        rb = GetComponent<Rigidbody>();
        onGround = true;
        boostThrust = 20;
        boostCapacity = 100;
        boostCapacityMirror = boostCapacity;
        boosting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (onGround)
        {
            if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
            {
                isMoving = true;

                if (Input.GetButton("Vertical"))
                {
                    thrust = Time.deltaTime * 1555 * Input.GetAxis("Vertical");
                    rb.AddForce(transform.forward * thrust);
                }
                if (Input.GetButton("Horizontal"))
                {
                    if (Vector3.Dot(transform.up, Vector3.down) > 0)
                    {
                        rb.AddTorque(transform.forward * 25.0f * Input.GetAxis("Horizontal"));
                    }
                    //thrust = (Time.deltaTime + 0.2f) * 1000 * Input.GetAxis("Horizontal");
                    if (rb.angularVelocity.magnitude < 1.0f)
                    {
                        rb.AddTorque(transform.up * 125.0f * Input.GetAxis("Horizontal"));
                    }
                }
            }
            if (Input.GetKey("space"))
            {
                if (boostCapacity > 1)
                {
                    boosting = true;
                    rb.AddForce(transform.forward * boostThrust);
                    print("Boosting! Capacity: " + boostCapacity);
                    boostCapacity -= 50 * Time.deltaTime;

                }
            }
            else
            {
                boosting = false;
                
                //rb.velocity = rb.velocity * 0.8f; 
                //print("No longer boosting");
                thrust = 0;
            }
            boostCapacityMirror = boostCapacity;
        }
        if(!boosting)
        {
            if (boostCapacity < 100) // checks so you won't add more boost fuel when it's full. 
            { boostCapacity += 4.75f * Time.deltaTime; }
        }

    }

    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.name == "floor")
        {
            onGround = true;

        }
    }
    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.name == "floor")
        {
            onGround = false;
        }
    }
}
