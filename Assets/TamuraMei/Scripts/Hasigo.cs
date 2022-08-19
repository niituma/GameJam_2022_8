using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hasigo : TaskBase
{
    public override void Action()
    {
        _player.CatchLadder();
    }
}
