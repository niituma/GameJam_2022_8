using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>�L�������L���b�`</summary>
public class RescueCat : TaskBase
{
    public override void Action()
    {
        _player.UsedLadder();
        Clear();
    }
}
