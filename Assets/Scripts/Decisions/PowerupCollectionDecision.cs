using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PowerupCollectionDecision", menuName = "Decisions/PowerupCollectionDecision")]
public class PowerupCollectionDecision : Decision
{
    public StateTransformMap[] map;
    public override bool Decide(StateController controller)
    {
        PlayerStateController p = (PlayerStateController)controller;

        PlayerState toCompareState = EnumExtension.ParseEnum<PlayerState>(p.currentState.name);
        // loop through state transform and see if it matches the current transformation we are looking for
        for (int i = 0; i < map.Length; i++)
        {
            if (toCompareState == map[i].fromState && p.currentPowerupType == map[i].powerupCollected)
            {
                return true;
            }
        }

        return false;
    }
}

[System.Serializable]
public struct StateTransformMap
{
    public PlayerState fromState;
    public PowerupType powerupCollected;
}
