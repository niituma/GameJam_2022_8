using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>”L‚¿‚á‚ñ‚ðƒLƒƒƒbƒ`</summary>
public class RescueCat : TaskBase
{
    public override void Action()
    {
        _player.UsedLadder();
        Clear();
    }
}
