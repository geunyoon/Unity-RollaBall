using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Transform respawnPoint;
    //referencing the respawn point and player

    void OnTriggerEnter(Collider other)
    {
        player.transform.position = respawnPoint.transform.position;
        //matching the respawn point
    }
}
