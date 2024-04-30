using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WorkWeekState : IState
{
    protected readonly IStateSwitcher StateSwitcher;
    private readonly Character _character;

    protected WorkWeekState(IStateSwitcher stateSwitcher, Character character)
    {
        StateSwitcher = stateSwitcher;
        _character = character;
    }

  
  
    public virtual void Enter()
    {
        Debug.Log("Начато: ");
    }

    public virtual void Exit()
    {
        Debug.Log("Завершено: ");
    }

    public virtual void Update()
    {
      
    }
}

