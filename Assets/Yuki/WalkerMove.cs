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
    [SerializeField, Tooltip("左方向制限範囲")] float _leftMove;
    [SerializeField, Tooltip("右方向制限範囲")] float _rightMove;
    [SerializeField, Tooltip("上方向制限範囲")] float _topMove;
    [SerializeField, Tooltip("下方向制限範囲")] float _bottomMove;
    [Tooltip("通行人ポジション")] Transform _walkerPositon;
    [Tooltip("前回移動時のX座標")] float _oldX;
    Vector2 _walkerScale;
    [SerializeField, Header("歩行スピード")] float _walkerSpeed;
    Vector2 _moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        _walkerPositon = GetComponent<Transform>();
        _oldX = _walkerPositon.position.x;
        _moveDirection = MoveRandomPosition();
    }


    // Update is called once per frame
    void Update()
    {
        //前回のX座標からどちらに動いたかで向きを決定
        _walkerScale = this.transform.localScale;
        if (_walkerPositon.position.x <= _oldX && 1 == _walkerScale.x)   //左に移動 かつ 現在スプライトが右向きだったら、左向きに変更
        {
            _walkerScale.x = -1;
        }
        else if (_walkerPositon.position.x > _oldX && _walkerScale.x == -1)   //右に移動 かつ 現在スプライトが左向きだったら、右向きに変更
        {
            {
                _walkerScale.x = 1;
            }
        }
        else
        {
            return;
        }

        //通行人の移動＆跳ね返り処理
        if (_moveDirection.x == _walkerPositon.position.x && _moveDirection.y == _walkerPositon.position.y)  //playerオブジェクトが目的地に到達すると、
        {
            _moveDirection = MoveRandomPosition();  //目的地を再設定
        }
        this.transform.position = Vector2.MoveTowards(this.transform.position, _moveDirection, _walkerSpeed * Time.deltaTime);



        _oldX = _walkerPositon.position.x;
    }


    private Vector2 MoveRandomPosition()  // 目的地を生成、xとyのポジションをランダムに値を取得 
    {
        Vector2 _randomPosi = new Vector2(Random.Range((int)_leftMove, (int)_rightMove), Random.Range((int)_bottomMove, (int)_topMove));
        return _randomPosi;
    }
}
