using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private CharacterStateMachine _stateMachine;

    private void Awake()
    { 
        _stateMachine = new CharacterStateMachine(this);
    }

    private void Update()
    {
        _stateMachine.Update();
    }
}
