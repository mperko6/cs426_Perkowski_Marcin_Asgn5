using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PacketSpawner : NetworkBehaviour
{
    public GameObject packetSpawnPrefab;
    public int numPackets;

    public override void OnStartServer() {

        /*for(int i = 0; i < numPackets; i++) {
            //var pos = new Vector3(Random.Range(-8.0f, 8.0f), 0.2f, Random.Range(-8.0f, 8.0f));
            var pos = new Vector3(2.0f, 1f, -2.0f);
            var rotation = Quaternion.Euler(0, 0, 0);
            var prefab = (GameObject)Instantiate(packetSpawnPrefab, pos, rotation);
            NetworkServer.Spawn(prefab);
        }*/

        /*var pos = new Vector3(20.0f, 1f, 20.0f);
        var rotation = Quaternion.Euler(0, 0, 0);
        var prefab = (GameObject)Instantiate(packetSpawnPrefab, pos, rotation);
        NetworkServer.Spawn(prefab);

        pos = new Vector3(10.0f, 16f, 10.0f);
        rotation = Quaternion.Euler(0, 0, 0);
        prefab = (GameObject)Instantiate(packetSpawnPrefab, pos, rotation);
        NetworkServer.Spawn(prefab);

        pos = new Vector3(-10.0f, 1f, 20.0f);
        rotation = Quaternion.Euler(0, 0, 0);
        prefab = (GameObject)Instantiate(packetSpawnPrefab, pos, rotation);
        NetworkServer.Spawn(prefab);

        pos = new Vector3(-20.0f, 16f, 20.0f);
        rotation = Quaternion.Euler(0, 0, 0);
        prefab = (GameObject)Instantiate(packetSpawnPrefab, pos, rotation);
        NetworkServer.Spawn(prefab);

        pos = new Vector3(-12.5f, 6f, 2.5f);
        rotation = Quaternion.Euler(0, 0, 0);
        prefab = (GameObject)Instantiate(packetSpawnPrefab, pos, rotation);
        NetworkServer.Spawn(prefab);

        pos = new Vector3(-17.0f, 6f, -17.0f);
        rotation = Quaternion.Euler(0, 0, 0);
        prefab = (GameObject)Instantiate(packetSpawnPrefab, pos, rotation);
        NetworkServer.Spawn(prefab);

        pos = new Vector3(-20.0f, 11f, 0.0f);
        rotation = Quaternion.Euler(0, 0, 0);
        prefab = (GameObject)Instantiate(packetSpawnPrefab, pos, rotation);
        NetworkServer.Spawn(prefab);

        pos = new Vector3(-20.0f, 21f, -10.0f);
        rotation = Quaternion.Euler(0, 0, 0);
        prefab = (GameObject)Instantiate(packetSpawnPrefab, pos, rotation);
        NetworkServer.Spawn(prefab);

        pos = new Vector3(0.0f, 16f, -22.5f);
        rotation = Quaternion.Euler(0, 0, 0);
        prefab = (GameObject)Instantiate(packetSpawnPrefab, pos, rotation);
        NetworkServer.Spawn(prefab);

        pos = new Vector3(20.0f, 11f, 0.0f);
        rotation = Quaternion.Euler(0, 0, 0);
        prefab = (GameObject)Instantiate(packetSpawnPrefab, pos, rotation);
        NetworkServer.Spawn(prefab);*/
    }
}
