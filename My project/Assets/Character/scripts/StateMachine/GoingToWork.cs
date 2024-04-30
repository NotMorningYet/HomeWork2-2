using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoingToWork : WorkWeekState
{
    public GoingToWork(IStateSwitcher stateSwitcher, Character character) : base(stateSwitcher, character)
    {
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log(GetType());
    }
    public override void Exit()
    {
        base.Exit();
        Debug.Log(GetType());
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StateSwitcher.SwitchState<Work>();
        }
    }
}
