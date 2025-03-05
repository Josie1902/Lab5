using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InvincibilityAction", menuName = "Actions/InvincibilityAction")]
public class InvincibilityAction : Action
{
    public override void Act(StateController controller)
    {
        PlayerController player = controller.GetComponent<PlayerController>();
        if (player != null)
        {
            player.SetInvincible(true);
            player.SetInvincibleColor();
        }
        else
        {
            Debug.LogWarning("PlayerMovement script not found on player!");
        }
    }
}
