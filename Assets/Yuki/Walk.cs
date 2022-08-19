using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// まっすぐ左右に動く通行人の移動を制御するスクリプト。該当の通行人のPrefabにアタッチする。
/// </summary>
public class Walk : MonoBehaviour
{
    [SerializeField, Header("道路左端")] float _leftLine;
    [SerializeField, Header("道路右端")] float _rightLine;
    [SerializeField, Header("道路上端")] float _topLine;
    [SerializeField, Header("道路下端")] float _bottomLine;
    [Tooltip("左右どちらに動くか抽選")] int _horizonSelect;
    [SerializeField, Header("歩行スピード")] float _walkerSpeed;
    [Tooltip("移動先の座標")] Vector2 _moveDirection;
    bool goRight;


    // Start is called before the first frame update
    void Start()
    {
        _horizonSelect = Random.Range(0, 2);

        if (_horizonSelect == 0) //0なら"初動"は左向き
        {
            _moveDirection = new Vector2(_leftLine, this.transform.position.y);
            goRight = false;
        }
        else //1なら"初動"右向き
        {
            _moveDirection = new Vector2(_rightLine, this.transform.position.y);
            goRight = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector2.MoveTowards(this.transform.position, _moveDirection, _walkerSpeed * Time.deltaTime);  //目的地へ移動
        if(_moveDirection.x == this.transform.position.x)
        {
            ChangeDirection();
        }
    }

    /// <summary>
    /// 端に到達したら呼ばれる、方向転換するメソッド
    /// </summary>
    private void ChangeDirection()
    {
        if(goRight)
        {
            Debug.Log("左に向く");
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
            _moveDirection = new Vector2(_leftLine, this.transform.position.y);
            goRight = false;
        }
        else
        {
            Debug.Log("右に向く");
            this.transform.rotation = Quaternion.Euler(0, 180, 0);
            _moveDirection = new Vector2(_rightLine, this.transform.position.y);
            goRight = true;
        }
    }
}

