using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>���D���L���b�`</summary>
public class CatchBalloon : TaskBase
{
    public override void Action()
    {
        _player.PassBalloon();
        Clear();
    }
}
