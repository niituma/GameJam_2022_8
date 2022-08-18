using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescueCat : TaskBase
{
    [SerializeField] bool _help; //梯子つかう

    void Update()
    {
        //ボタン押されたら_helpをtrueに
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (_help)
        {
            //消える前の処理してからクリア
            //猫と子供がよろこぶアニメーション？
            Clear();
        }
    }
}
