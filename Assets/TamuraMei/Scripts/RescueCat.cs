using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>猫ちゃんをキャッチ</summary>
public class RescueCat : TaskBase
{
    public override void Action()
    {
        _player.UsedLadder();
        Clear();
    }
}
