using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    private State playerState;

    /// <summary>
    /// Actual player health
    /// </summary>
    private int _PlayerHealth = 5;

    /// <summary>
    /// Reference to the players health
    /// </summary>
    public int PlayerHealth
    {
        get { return _PlayerHealth; }
    }


    private void Start()
    {
        playerState = new Idle(this.gameObject);
    }

    private void Update()
    {
        playerState = playerState.Process();
    }

}
