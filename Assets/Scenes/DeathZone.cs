using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    [SerializeField]
    private Transform respawnPoint = null;

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<MovePlayer>() != null)
        {
            MovePlayer player = other.GetComponent<MovePlayer>();
            if (player.IsSafe != true)
                player.transform.position = respawnPoint.transform.position;

        }
    }
}
    
