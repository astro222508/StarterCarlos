using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : State
{
    //Player has left clicked and is attempting to throw a sword forward 

    //Get reference to the players info 
    PlayerInfo playerInfo = GameManager.Singleton.PlayerInfo;

    public Attack(GameObject player) : base(player)
    {

    }

    public override void Enter()
    {



        base.Enter();
    }

    public override void Update()
    {
        //Check if player is holding fire button 
        if (Input.GetMouseButton(0))
        {
            //Show a rough trajectory of where the shot would go 
        }
        else
        {
            //Check if the player can fire
            if (playerInfo.CheckAmmoSupply(1))
            {
                //Launch Sword in given direction

                //Exit state 
                nextStage = new Idle(this.npc);

                stage = EVENT.EXIT;

                return; 
            }
            else
            {
                //Player does not have enough swords 
                //Just leave for now 

                //Exit state 
                nextStage = new Idle(this.npc);

                stage = EVENT.EXIT;

                return;
            }
        }



    }

    public override void Exit()
    {
        base.Exit();
    }

}
