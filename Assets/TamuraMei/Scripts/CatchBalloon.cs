using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>���D���L���b�`</summary>
public class CatchBalloon : TaskBase
{
    public override void Action()
    {

        if(_player.Haveballoon)
        {
            _player.PassBalloon();
            Clear();
        }
        else
        {
            return;
        }
        
    }
}
