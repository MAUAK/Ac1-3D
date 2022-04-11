using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData_New", menuName = "GameData")]
public class GameData_SO : ScriptableObject, ISerializationCallbackReceiver
{
    public int score = 0;
    public int pulo = 0;

    public void OnAfterDeserialize()
    {
        score = 0;
        pulo = 0;
    }

    public void OnBeforeSerialize()
    {

    }
}