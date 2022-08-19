using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// あちこちに動く通行人の移動を制御するクラス。該当の通行人のPrefabにアタッチする。
/// </summary>
/// 
public class RandomWalkControll : MonoBehaviour
{
    [SerializeField, Header("道路左端")] float _leftLine;
    [SerializeField, Header("道路右端")] float _rightLine;
    [SerializeField, Header("道路上端")] float _topLine;
    [SerializeField, Header("道路下端")] float _bottomLine;
    [Tooltip("前回移動時のX座標")] float _oldX;
    [SerializeField, Header("歩行スピード")] float _walkerSpeed;
    [Tooltip("ランダム移動先の座標")] Vector2 _moveDirection;

    void Start()
    {
        _oldX = this.transform.position.x;  // スポーン時のX座標を保存
        _moveDirection = MoveRandomPosition();  //最初の移動方向を設定
        if( _moveDirection.x < 0)
        {
            this.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    void Update()
    {
        //通行人の移動＆跳ね返り処理
        this.transform.position = Vector2.MoveTowards(this.transform.position, _moveDirection, _walkerSpeed * Time.deltaTime);//目的地へ移動

        if (_moveDirection.x == this.transform.position.x && _moveDirection.y == this.transform.position.y)  //目的地に到達したら
        {
            _oldX = _moveDirection.x;   //今回到達した目的地のX座標を保存しておく
            _moveDirection = MoveRandomPosition();  //次の目的地を再設定

            if (_moveDirection.x <= _oldX && this.transform.eulerAngles.y == 180)   //移動方向が右から左になるとき、スプライトが右向きだったら左向きに変更
            {
                this.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else /*if (_moveDirection.x > _oldX && this.transform.eulerAngles.y == 0)*/   //移動方向が左から右になるとき、スプライトが左向きだったら右向きに変更

            {
                this.transform.rotation = Quaternion.Euler(0, 0, 0);
            }

        }
    }


    private Vector2 MoveRandomPosition()  // 目的地を生成、xとyのポジションをランダムに値を取得 
    {
        float _ranWidth = Random.Range(_leftLine, _rightLine);
        float _ranHight = Random.Range(_bottomLine, _topLine);
        Vector2 _randomPosi = new Vector2(_ranWidth, _ranHight);
        return _randomPosi;
    }
}
