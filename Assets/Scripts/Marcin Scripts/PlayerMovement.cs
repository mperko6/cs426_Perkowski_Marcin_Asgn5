using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMovement : NetworkBehaviour {
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float flightForce = 3f;
    
    public float groundDistance = 0.4f;
    Vector3 velocity;
    public Transform groundCheck;
    public LayerMask groundMask;
    bool isGrounded;

    public GameObject laserPrefab;
    public GameObject cannon;

    [Command]
    void CmdFire() 
    {
        var laser = (GameObject)Instantiate(laserPrefab, cannon.transform.position, cannon.transform.rotation);
        laser.GetComponent<Rigidbody>().velocity = transform.forward * 40;

        NetworkServer.Spawn(laser);

        Destroy(laser, 5.0f);
    }


    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer) 
        {
            return;
        }

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(flightForce * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetMouseButtonDown(0)) 
        {
            CmdFire();
        }
    }
}
