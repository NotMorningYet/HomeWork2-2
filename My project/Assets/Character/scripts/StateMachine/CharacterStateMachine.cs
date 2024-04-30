using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CharacterStateMachine : IStateSwitcher
{
    private List<IState> _states;
    private IState _currentState;

    public CharacterStateMachine(Character character)
    {
        _states = new List<IState>()
        {
            new GoingToWork(this, character),
            new Work(this, character),
            new GoingHome(this, character),
            new Rest(this, character),
        };

        _currentState = _states[0];
        _currentState.Enter();
    }

    public void SwitchState<T>() where T : IState
    {
        IState state = _states.FirstOrDefault(state => state is T);
        _currentState.Exit();
        _currentState = state;
        _currentState.Enter();
    }
 

    public void Update() => _currentState.Update();


}
