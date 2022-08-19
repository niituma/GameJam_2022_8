using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonChild : TaskBase
{
    public override void Action()
    {
        if (!_player.Haveballoon) { return; }
        _player.PassBalloon();
        Clear();
    }
}
