using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ���������ɓ����ʍs�l�̈ړ��𐧌䂷��X�N���v�g�B�Y���̒ʍs�l��Prefab�ɃA�^�b�`����B
/// </summary>
/// 
public class RandomWalkControll : MonoBehaviour
{
    [SerializeField, Tooltip("���H�]�[�����[")] float _leftMove;
    [SerializeField, Tooltip("���H�]�[���E�[")] float _rightMove;
    [SerializeField, Tooltip("���H�]�[����[")] float _topMove;
    [SerializeField, Tooltip("���H�]�[�����[")] float _bottomMove;
    [Tooltip("�O��ړ�����X���W")] float _oldX;
    [SerializeField, Header("���s�X�s�[�h")] float _walkerSpeed;
    [Tooltip("�����_���ړ���̍��W")] Vector2 _moveDirection;

    void Start()
    {
        _oldX = this.transform.position.x;  // �X�|�[������X���W��ۑ�
        _moveDirection = MoveRandomPosition();  //�ŏ��̈ړ�������ݒ�
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
                Debug.Log("���Ɍ���");
                this.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else /*if (_moveDirection.x > _oldX && this.transform.eulerAngles.y == 0)*/   //�ړ�������������E�ɂȂ�Ƃ��A�X�v���C�g����������������E�����ɕύX

            {
                Debug.Log("�E�Ɍ���");
                this.transform.rotation = Quaternion.Euler(0, 180, 0);
            }

        }
    }


    private Vector2 MoveRandomPosition()  // �ړI�n�𐶐��Ax��y�̃|�W�V�����������_���ɒl���擾 
    {
        float _ranWidth = Random.Range(_leftMove, _rightMove);
        float _ranHight = Random.Range(_bottomMove, _topMove);
        Vector2 _randomPosi = new Vector2(_ranWidth, _ranHight);
        return _randomPosi;
    }
}
