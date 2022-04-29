using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManager : MonoBehaviour
{

    private State playerState;

    


    private void Start()
    {
        playerState = new Idle(this.gameObject);
    }

    private void Update()
    {
        playerState = playerState.Process();
    }

}
