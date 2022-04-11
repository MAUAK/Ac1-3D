using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager INSTANCE;

    private void Awake()
    {
        if (INSTANCE == null)
        {
            INSTANCE = this;
        } else
        {
            Destroy(gameObject);
        }
    }

    public CamManager camManager;
    public Player player;

    public GameData_SO gameData;
    public HudManager hudManager;

    public void ChangeCam(CinemachineVirtualCamera cam)
    {
        camManager.ChangeCam(cam);
    }

    public void AddPoint(int value)
    {
        gameData.score += value;
        hudManager.SetScore(gameData.score);

    }
    public void SetPulo(int value)
    {
        gameData.pulo += value;
        hudManager.SetPulo(gameData.pulo);
    }

    public void LoadMyScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
