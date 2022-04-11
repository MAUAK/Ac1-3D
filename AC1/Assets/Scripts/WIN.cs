using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WIN : MonoBehaviour
{
    public HudManager hdmanager;


    private void OnCollisionEnter(Collision collision)
    {
        hdmanager.GameWin();

    }
}
