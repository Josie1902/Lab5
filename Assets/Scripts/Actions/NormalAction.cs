using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NormalAction", menuName = "Actions/NormalAction")]
public class NormalAction : Action
{
    public override void Act(StateController controller)
    {
        PlayerStateController p = (PlayerStateController)controller;
        p.currentPowerupType = PowerupType.Default;
        PlayerController player = controller.GetComponent<PlayerController>();
        player.SetInvincible(false);
        player.ResetSpeed();
        player.ResetColor();
    }
}