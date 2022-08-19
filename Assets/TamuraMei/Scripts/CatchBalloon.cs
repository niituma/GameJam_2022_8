using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>風船をキャッチ</summary>
public class CatchBalloon : TaskBase
{
    public override void Action()
    {
        Clear();
        _player.PassBalloon();
    }
}
