using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State
{

    //State for when the player is just standing 


    #region Input variables

    private float _HorizontalInput;
    private float _VerticalInput;


    #endregion

    public Idle(GameObject playerObj) : base(playerObj)
    {

    }

    public override void Enter()
    {
        npc.GetComponent<MeshRenderer>().material.color = Color.green;
        base.Enter();
    }

    public override void Update()
    {
        //Update inputs 
        CheckForNewState();

    }

    public override void Exit()
    {
        base.Exit();
    }

    public void CheckForNewState()
    {
        Debug.Log("New states");
        if (AttackInput())
        {
            Debug.Log("New attack");

            nextStage = new Attack(this.npc);
            stage = EVENT.EXIT;
            return;
        }

        if (MovementInput())
        {

            Debug.Log("New move");

            nextStage = new Movement(this.npc);
            stage = EVENT.EXIT;
            return;
        }

    }


    /// <summary>
    /// Check if any movement controls were made
    /// </summary>
    /// <returns></returns>
    public bool MovementInput()
    {
        //Update movement variables
        _HorizontalInput = Input.GetAxis("Horizontal");
        _VerticalInput = Input.GetAxis("Vertical");

        if(_HorizontalInput != 0)
        {
            return true;
        }

        if(_VerticalInput != 0)
        {
            return true;
        }

        

        return false;
    }

    public bool AttackInput()
    {
        /*
        //Check for a left click
        if (Input.GetMouseButtonDown(0))
        {
            
            return true;

        }
        */
        return false;
    }

}
