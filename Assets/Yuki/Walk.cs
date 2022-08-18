using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    [SerializeField, Tooltip("���H�]�[�����[")] float _leftMove;
    [SerializeField, Tooltip("���H�]�[���E�[")] float _rightMove;
    [SerializeField, Tooltip("���H�]�[����[")] float _topMove;
    [SerializeField, Tooltip("���H�]�[�����[")] float _bottomMove;
    [Tooltip("���E�ǂ���ɓ��������I")] int _horizonSelect;
    [SerializeField, Header("���s�X�s�[�h")] float _walkerSpeed;

    float _xPos;
    bool goRight;


    // Start is called before the first frame update
    void Start()
    {
        _horizonSelect = Random.Range(0, 2);
        _xPos = this.transform.position.x;
        if (_horizonSelect == 0) //0�Ȃ�"����"�͍�����
        {
            goRight = false;
        }
        else //1�Ȃ�"����"�E����
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
    /// ���E�ɕ����A�[�ɓ��B����������]�����郁�\�b�h
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

            Debug.Log("���Ɍ���");
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

            Debug.Log("�E�Ɍ���");
            this.transform.rotation = Quaternion.Euler(0, 180, 0);
            goRight = true;
        }
    }

}

