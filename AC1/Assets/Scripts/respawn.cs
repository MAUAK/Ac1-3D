using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public HudManager hdmanager;

    public string sceneName;

    public float time =3;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        hdmanager.GameOver();

        Invoke("CarregarCena", time);
        
    }

    private void CarregarCena()
    {
        GameManager.INSTANCE.LoadMyScene(sceneName);
    }
    
}
