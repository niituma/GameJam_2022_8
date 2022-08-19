using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hasigo : TaskBase
{
    public override void Action()
    {

        if(!_player.HaveLadder)
        {
            _player.CatchLadder();
            Clear();
        }
        else
        {
            return;
        }
        
    }
}
