using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;
public class Guard : MonoBehaviour
{
    public GameObject player;
    private Rigidbody rb;
    private NavMeshAgent navmesh;
    public float movement_speed;
    public float rotation_speed;
    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        navmesh = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
        movement_speed = 5.0f;
        rotation_speed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //constantly turn towards player
        
        if (InSights())
        {
            //float thrust = Time.deltaTime * 1555 * Input.GetAxis("Vertical");
            //rb.AddForce(transform.forward * thrust);
            rb.AddForce(this.transform.forward * movement_speed);
            Vector3 target_direction = Vector3.RotateTowards(this.transform.forward, player.transform.position - this.transform.position, rotation_speed / 4 * Time.deltaTime, 0.0f);
            this.transform.forward = target_direction;
        }
        else
        {
            Vector3 target_direction = Vector3.RotateTowards(this.transform.forward, player.transform.position - this.transform.position, rotation_speed * Time.deltaTime, 0.0f);
            this.transform.forward = target_direction;
            //rb.AddForce(this.transform.forward * movement_speed *-1);
        }
        if (Vector3.Distance(this.transform.position, player.transform.position) < 5)
        {
            
        }
    }
    //check if the Guard is facing towards the player within a certain amount of degrees
    bool InSights()
    {
        Vector3 guard_direction = this.transform.forward;
        Vector3 guard_to_player_vector = player.transform.position - this.transform.position;
        if (Vector3.Angle(guard_direction, guard_to_player_vector) < 20.0f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
