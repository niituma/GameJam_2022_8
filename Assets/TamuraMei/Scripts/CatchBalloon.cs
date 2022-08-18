using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>風船をキャッチ</summary>
public class CatchBalloon : TaskBase
{
    [SerializeField] bool _catch;

    // Update is called once per frame
    void Update()
    {
        //ボタン押したら_catchをtrueに
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(_catch)
        {
            //消える前の処理してからクリア
            //子供が喜ぶアニメーション？
            Clear();
        }
    }
}
