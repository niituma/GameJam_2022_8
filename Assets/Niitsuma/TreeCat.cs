using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCat : ActionBase
{
    // Start is called before the first frame update
    public override void Action()
    {
        if (_player.HaveLadder && _isAction)
        {
            _player.UsedLadder();
            _isAction = false;
            Debug.Log("Cat");
        }
    }
}
