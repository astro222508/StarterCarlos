using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameManager 
{

    /// <summary>
    /// Hold this singleton
    /// </summary>
    private static GameManager instance;

    private PlayerInfo _PlayerInfo = new PlayerInfo();
    public PlayerInfo PlayerInfo { get { return _PlayerInfo; } }


    /// <summary>
    /// Create the singleton
    /// </summary>
    public static GameManager Singleton
    {
        get
        {
            
            if (instance == null)
            {
                instance = new GameManager();
                
            }

            return instance;
        }
    }

}
