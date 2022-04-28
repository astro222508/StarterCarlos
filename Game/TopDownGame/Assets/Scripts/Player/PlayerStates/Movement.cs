using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : State
{

   //Store movement inputs
    private float _HorizontalInput;
    private float _VerticalInput;

    private float moveSpeed;

    public Movement(GameObject player) : base(player)
    {
        npc.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public override void Enter()
    {
        moveSpeed =  10;

        base.Enter();
    }

    public override void Update()
    {

        
        UpdateInputs();



        //Move player
        MovePlayer();


    }

    public override void Exit()
    {
        base.Exit();
    }
    
    public void UpdateInputs()
    {
        _HorizontalInput = Input.GetAxis("Horizontal") * moveSpeed;
        _VerticalInput = Input.GetAxis("Vertical") * moveSpeed;

        if(_HorizontalInput == 0 && _VerticalInput == 0)
        {
            nextStage = new Idle(this.npc);
            stage = EVENT.EXIT;
            return;
        }

        
    }

    public void MovePlayer()
    {
        this.npc.transform.position = new Vector3(npc.transform.position.x + _HorizontalInput * Time.deltaTime, npc.transform.position.y, npc.transform.position.z + _VerticalInput * Time.deltaTime);
    }

}
