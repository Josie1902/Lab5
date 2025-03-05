using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DurationExpirationDecision", menuName = "Decisions/DurationExpirationDecision")]
public class DurationExpirationDecision : Decision
{
    public float duration = 10f;

    public override bool Decide(StateController controller)
    {
        return controller.CheckIfCountDownElapsed(duration);
    }
}
