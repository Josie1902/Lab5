using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState { Default, Sped, Invincible }

public class PlayerStateController : StateController
{
    public PowerupType currentPowerupType = PowerupType.Default;

    public override void Start()
    {
        base.Start();
        GameRestart(); // clear powerup in the beginning, go to start state
    }

    // this should be added to the GameRestart EventListener as callback
    public void GameRestart()
    {
        // clear powerup
        currentPowerupType = PowerupType.Default;
        // set the start state
        TransitionToState(startState);
    }

    public void SetPowerup(PowerupType i)
    {
        currentPowerupType = i;
    }

}
