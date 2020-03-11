using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserHit : MonoBehaviour
{
    public ScoreTracker scoreManager;

    void OnCollisionEnter(Collision collision) {

        var hit = collision.gameObject;

        if (collision.gameObject.tag == "Laser") {
            scoreManager.AddPoint();
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }
}
