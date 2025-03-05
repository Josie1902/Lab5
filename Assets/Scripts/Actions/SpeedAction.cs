using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpeedBoostAction", menuName = "Actions/SpeedBoostAction")]
public class SpeedBoostAction : Action
{
    public float speedBoost = 2f;

    public override void Act(StateController controller)
    {
        PlayerController player = controller.GetComponent<PlayerController>();
        if (player != null)
        {
            player.SetSpeed(player.defaultSpeed * speedBoost);
            player.SetSpeedColor();
        }
        else
        {
            Debug.LogWarning("PlayerMovement script not found on player!");
        }
    }
}

