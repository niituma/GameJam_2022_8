using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    [SerializeField, Tooltip("道路ゾーン左端")] float _leftMove;
    [SerializeField, Tooltip("道路ゾーン右端")] float _rightMove;
    [SerializeField, Tooltip("道路ゾーン上端")] float _topMove;
    [SerializeField, Tooltip("道路ゾーン下端")] float _bottomMove;
    [Tooltip("左右どちらに動くか抽選")] int _horizonSelect;
    [SerializeField, Header("歩行スピード")] float _walkerSpeed;

    float _xPos;
    bool goRight;


    // Start is called before the first frame update
    void Start()
    {
        _horizonSelect = Random.Range(0, 2);
        _xPos = this.transform.position.x;
        if (_horizonSelect == 0) //0なら"初動"は左向き
        {
            goRight = false;
        }
        else //1なら"初動"右向き
        {
            goRight = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        MoveAndTurn();
    }

    /// <summary>
    /// 左右に歩き、端に到達したら方向転換するメソッド
    /// </summary>
    void MoveAndTurn()
    {
        if (goRight)
        {
            while (this.transform.position.x < _rightMove)
            {
                _xPos += _walkerSpeed * Time.deltaTime;
                this.transform.position = new Vector2(_xPos, this.transform.position.y);
            }

            Debug.Log("左に向く");
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
            goRight = false;
        }
        else
        {
            while (transform.position.x > _leftMove)
            {
                _xPos -= _walkerSpeed * Time.deltaTime;
                this.transform.position = new Vector2(_xPos, this.transform.position.y);
            }

            Debug.Log("右に向く");
            this.transform.rotation = Quaternion.Euler(0, 180, 0);
            goRight = true;
        }
    }

}

