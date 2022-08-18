using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 通行人の移動を制御するスクリプト。通行人のPrefabにアタッチする。
/// </summary>
/// 
public class WalkerMove : MonoBehaviour
{
    [Tooltip("左方向制限範囲")] float _leftMove;
    [Tooltip("右方向制限範囲")] float _rightMove;
    [Tooltip("上方向制限範囲")] float _topMove;
    [Tooltip("下方向制限範囲")] float _bottomMove;
    [Tooltip("通行人ポジション")] Transform _walkerPositon;
    [Tooltip("前回移動時のX座標")] float _oldX;
    Vector3 _walkerScale;

    // Start is called before the first frame update
    void Start()
    {
        _walkerPositon = GetComponent<Transform>();
        _oldX = _walkerScale.x;
    }


    // Update is called once per frame
    void Update()
    {
        //通行人の移動＆跳ね返り処理
        



        //前回のX座標からどちらに動いたかで向きを決定
        _walkerScale = transform.localScale;
        if (_walkerPositon.position.x < _oldX && 0 <= _walkerScale.x)   //左に移動 かつ 現在スプライトが右向きだったら、左向きに変更
        {
            _walkerScale.x = -1;
        }
        else if (_walkerPositon.position.x > _oldX && _walkerScale.x < 0)   //右に移動 かつ 現在スプライトが左向きだったら、右向きに変更
        {
            {
                _walkerScale.x = 1;
            }
        }
        else
        {
            return;
        }
    }
}
