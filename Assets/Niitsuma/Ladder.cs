using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : ActionBase
{
    public override void Spawn()
    {

    }
    public override void Action()
    {
        _player.CatchLadder();
    }
}
