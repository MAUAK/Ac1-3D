using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Player CodPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.INSTANCE.SetPulo(1);
            CodPlayer.forceJump = 600;
            Destroy(gameObject);
        }
    }
}
