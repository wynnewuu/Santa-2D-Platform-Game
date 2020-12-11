using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<MovePlayer>() != null)
        {
            MovePlayer p = other.GetComponent<MovePlayer>();
            p.IsSafe = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<MovePlayer>() != null)
        {
            MovePlayer p = other.GetComponent<MovePlayer>();
            p.IsSafe = false;
        }
    }
}
