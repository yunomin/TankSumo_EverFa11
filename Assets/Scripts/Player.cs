using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject guard;
    private Rigidbody rb;
    private Rigidbody guard_rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        guard_rigidbody = guard.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(Vector3.forward * 20);
        if (Input.GetKey(KeyCode.DownArrow))
            rb.AddForce(Vector3.back * 20);
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(Vector3.left * 20);
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(Vector3.right * 20);
        if (Input.GetKey(KeyCode.Space))
        {
            /*
            this.GetComponent<BoxCollider>().enabled = true;
            this.GetComponent<BoxCollider>().enabled = false;
            */
            if (Vector3.Angle(this.transform.forward, guard.transform.position - this.transform.position) < 20.0f
                && Vector3.Distance(this.transform.position, guard.transform.position) < 20.0f)
            {
                guard_rigidbody.AddForce(this.transform.forward * 200);
            }
        }
    }

    void OnTriggerEnter(Collider blast_zone)
    {
        
    }
}
