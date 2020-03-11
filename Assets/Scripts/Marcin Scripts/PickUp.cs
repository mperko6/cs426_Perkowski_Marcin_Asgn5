using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PickUp : NetworkBehaviour
{
    [SerializeField] float throwForce = 50;
    [SerializeField] private float pickupAbleDistance = 2f;

    private Vector3 objectPos;
    private float distanceToPlayer;
    private Rigidbody throwableRigidBody;
    private ObjectHolder playerObjectHolder;
    private bool isHolding = false;

    /*private void OnCollisionEnter(Collision collision) {
        Debug.Log("collided with packet");
        playerObjectHolder = collision.objectHolder;
    }*/

    private void Start()
    {
        //playerObjectHolder = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<ObjectHolder>();
        throwableRigidBody = this.GetComponent<Rigidbody>();
    }

    void LateUpdate()
    {

        playerObjectHolder = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<ObjectHolder>();

        DetectInput();

        distanceToPlayer = Vector3.Distance(transform.position, playerObjectHolder.transform.position);

        if (distanceToPlayer >= pickupAbleDistance)
        {
            isHolding = false;
        }

        if (isHolding)
        {
            transform.SetParent(playerObjectHolder.transform);
            transform.localPosition = Vector3.zero;
            throwableRigidBody.velocity = Vector3.zero;
            throwableRigidBody.angularVelocity = Vector3.zero;
            throwableRigidBody.useGravity = false;

            if (Input.GetButtonDown("Fire1"))
            {
                Debug.Log("clicked to throw");
                isHolding = false;
                throwableRigidBody.AddForce(playerObjectHolder.transform.forward * throwForce, ForceMode.Impulse);
            }
        }
        else
        {
            transform.SetParent(null);
            throwableRigidBody.useGravity = true;
        }
    }

    void DetectInput()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (distanceToPlayer <= pickupAbleDistance)
            {
                isHolding = !isHolding;
                Debug.Log("pressed interact on throwable");
            }
        }
    }
}
