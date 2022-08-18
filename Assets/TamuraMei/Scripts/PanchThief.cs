using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanchThief : TaskBase
{
    [SerializeField] bool _panch;

    //ボタン押されたら_panchをtrueに

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(_panch)
        {
            //消える前の処理してからクリア
            //倒れるアニメーションとか？
            Clear();
        }
    }
}
