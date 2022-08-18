using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>一般人を殴ったとき</summary>
public class PanchPeople : TaskBase
{
    [SerializeField] bool _panch;

    // Update is called once per frame
    void Update()
    {
        //ボタン押したら_catchをtrueに
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (_panch)
        {
            //消える前の処理してからクリア
            //子供が喜ぶアニメーション？
            Clear();
        }
    }
}
