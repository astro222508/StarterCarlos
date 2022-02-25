using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//State machine base class
public class State 
{
   

    /// <summary>
    /// Stages of a state
    /// </summary>
    public enum EVENT
    {
        ENTER, UPDATE, EXIT 
    };

    /// <summary>
    /// What state  current being used
    /// </summary>
    public State stateName;

    /// <summary>
    /// Current stage of the state
    /// </summary>
    protected EVENT stage;

    /// <summary>
    /// Reference to object self 
    /// </summary>
    protected GameObject npc;

    /// <summary>
    /// Next state the machine should enter
    /// </summary>
    protected State nextStage;


    public State(GameObject _npa)
    {
        //Get reference to this game object.
        this.npc = _npa;
        //Set the process of the stage to enter
        this.stage = EVENT.ENTER;
    }

    /// <summary>
    /// This mehtod will run first then proceed to Update event.
    /// </summary>
    public virtual void Enter()
    {
        stage = EVENT.UPDATE;
    }


    /// <summary>
    /// This method will continue to run until next process is ran.
    /// </summary>
    public virtual void Update()
    {
        stage = EVENT.UPDATE;
    }

    /// <summary>
    /// Handles exit of state
    /// </summary>
    public virtual void Exit()
    {
        stage = EVENT.EXIT;
    }



    public State Process()
    {
        if (stage == EVENT.ENTER) Enter();
        if (stage == EVENT.UPDATE) Update();
        if (stage == EVENT.EXIT)
        {
            Exit();
            return stateName;
        }
        return this;
    }



}
