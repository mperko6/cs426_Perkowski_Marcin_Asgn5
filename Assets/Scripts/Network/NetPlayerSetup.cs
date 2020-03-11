using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NetPlayerSetup : NetworkBehaviour {

    [Header("References")]
    public Camera _cam;

    void Start() {
        if (isLocalPlayer) {
            Debug.Log(GetType().Name + " - Start() isLocalPlayer - " + gameObject.name);
        } else {
            // NETWORK: DISABLE COMPONENTS
            if (_cam != null) _cam.gameObject.SetActive(false);

            Debug.Log(GetType().Name + " - Start() !isLocalPlayer - Disabled components - " + gameObject.name);
        }
    }

    public override void OnStartLocalPlayer() {
        if (isLocalPlayer) {
            Debug.Log(GetType().Name + " - OnStartLocalPlayer() isLocalPlayer - " + gameObject.name);
        } else {
            Debug.Log(GetType().Name + " - OnStartLocalPlayer() !isLocalPlayer - " + gameObject.name);
        }
    }
}