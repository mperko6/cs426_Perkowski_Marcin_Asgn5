using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour {

    public AudioSource source;
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.Play();
    }
    void OnCollisionEnter(Collision collision) {

        var hit = collision.gameObject;
        Destroy(gameObject);
    }
}
