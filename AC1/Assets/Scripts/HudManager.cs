using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HudManager : MonoBehaviour
{
    public GameObject pnlGameObject;
    public GameObject pnlGameWin;

    public GameData_SO gamedata;

    public TMP_Text txtscore;
    public TMP_Text txtpulo;

    private void Start()
    {
        txtscore.text = gamedata.score.ToString();
        txtpulo.text = gamedata.pulo.ToString();
    }

    public void SetScore(int score)
    {
        txtscore.text = score.ToString();
    }
    public void SetPulo(int pulo)
    {
        txtpulo.text = pulo.ToString();
    }

    public void GameOver()
    {
        pnlGameObject.SetActive(true);
    }

    public void GameWin()
    {
        pnlGameWin.SetActive(true);
    }
}

