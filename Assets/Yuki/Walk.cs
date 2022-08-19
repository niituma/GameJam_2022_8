using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �܂��������E�ɓ����ʍs�l�̈ړ��𐧌䂷��X�N���v�g�B�Y���̒ʍs�l��Prefab�ɃA�^�b�`����B
/// </summary>
public class Walk : MonoBehaviour
{
    [SerializeField, Header("���H���[")] float _leftLine;
    [SerializeField, Header("���H�E�[")] float _rightLine;
    [SerializeField, Header("���H��[")] float _topLine;
    [SerializeField, Header("���H���[")] float _bottomLine;
    [Tooltip("���E�ǂ���ɓ��������I")] int _horizonSelect;
    [SerializeField, Header("���s�X�s�[�h")] float _walkerSpeed;
    [Tooltip("�ړ���̍��W")] Vector2 _moveDirection;
    bool goRight;


    // Start is called before the first frame update
    void Start()
    {
        _horizonSelect = Random.Range(0, 2);

        if (_horizonSelect == 0) //0�Ȃ�"����"�͍�����
        {
            _moveDirection = new Vector2(_leftLine, this.transform.position.y);
            goRight = false;
        }
        else //1�Ȃ�"����"�E����
        {
            _moveDirection = new Vector2(_rightLine, this.transform.position.y);
            goRight = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector2.MoveTowards(this.transform.position, _moveDirection, _walkerSpeed * Time.deltaTime);  //�ړI�n�ֈړ�
        if(_moveDirection.x == this.transform.position.x)
        {
            ChangeDirection();
        }
    }

    /// <summary>
    /// �[�ɓ��B������Ă΂��A�����]�����郁�\�b�h
    /// </summary>
    private void ChangeDirection()
    {
        if(goRight)
        {
            Debug.Log("���Ɍ���");
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
            _moveDirection = new Vector2(_leftLine, this.transform.position.y);
            goRight = false;
        }
        else
        {
            Debug.Log("�E�Ɍ���");
            this.transform.rotation = Quaternion.Euler(0, 180, 0);
            _moveDirection = new Vector2(_rightLine, this.transform.position.y);
            goRight = true;
        }
    }
}

