using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ���������ɓ����ʍs�l�̈ړ��𐧌䂷��N���X�B�Y���̒ʍs�l��Prefab�ɃA�^�b�`����B
/// </summary>
/// 
public class RandomWalkControll : MonoBehaviour
{
    [SerializeField, Header("���H���[")] float _leftLine;
    [SerializeField, Header("���H�E�[")] float _rightLine;
    [SerializeField, Header("���H��[")] float _topLine;
    [SerializeField, Header("���H���[")] float _bottomLine;
    [Tooltip("�O��ړ�����X���W")] float _oldX;
    [SerializeField, Header("���s�X�s�[�h")] float _walkerSpeed;
    [Tooltip("�����_���ړ���̍��W")] Vector2 _moveDirection;

    void Start()
    {
        _oldX = this.transform.position.x;  // �X�|�[������X���W��ۑ�
        _moveDirection = MoveRandomPosition();  //�ŏ��̈ړ�������ݒ�
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
        //�ʍs�l�̈ړ������˕Ԃ菈��
        this.transform.position = Vector2.MoveTowards(this.transform.position, _moveDirection, _walkerSpeed * Time.deltaTime);//�ړI�n�ֈړ�

        if (_moveDirection.x == this.transform.position.x && _moveDirection.y == this.transform.position.y)  //�ړI�n�ɓ��B������
        {
            _oldX = _moveDirection.x;   //���񓞒B�����ړI�n��X���W��ۑ����Ă���
            _moveDirection = MoveRandomPosition();  //���̖ړI�n���Đݒ�

            if (_moveDirection.x <= _oldX && this.transform.eulerAngles.y == 180)   //�ړ��������E���獶�ɂȂ�Ƃ��A�X�v���C�g���E�����������獶�����ɕύX
            {
                this.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else /*if (_moveDirection.x > _oldX && this.transform.eulerAngles.y == 0)*/   //�ړ�������������E�ɂȂ�Ƃ��A�X�v���C�g����������������E�����ɕύX

            {
                this.transform.rotation = Quaternion.Euler(0, 0, 0);
            }

        }
    }


    private Vector2 MoveRandomPosition()  // �ړI�n�𐶐��Ax��y�̃|�W�V�����������_���ɒl���擾 
    {
        float _ranWidth = Random.Range(_leftLine, _rightLine);
        float _ranHight = Random.Range(_bottomLine, _topLine);
        Vector2 _randomPosi = new Vector2(_ranWidth, _ranHight);
        return _randomPosi;
    }
}
