using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This creates a new Asset-Type (GameSettings) under the new Singletons-Folder
[CreateAssetMenu(menuName = "Singletons/GameSettings")]

public class GameSettings : ScriptableObject
{
    [SerializeField]
    private string _gameVersion = "0.0.0";
    public string GameVersion { get { return _gameVersion; } }

    [SerializeField]
    private string _nickname = "fish";
    public string Nickname
    {
        get
        {
            //Get a Random Value
            int value = Random.Range(0, 9999);
            return _nickname + value.ToString();
        }
    }
        
}
