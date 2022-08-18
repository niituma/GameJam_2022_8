using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �ʍs�l�̈ړ��𐧌䂷��X�N���v�g�B�ʍs�l��Prefab�ɃA�^�b�`����B
/// </summary>
/// 
public class WalkerMove : MonoBehaviour
{
    [SerializeField, Tooltip("�����������͈�")] float _leftMove;
    [SerializeField, Tooltip("�E���������͈�")] float _rightMove;
    [SerializeField, Tooltip("����������͈�")] float _topMove;
    [SerializeField, Tooltip("�����������͈�")] float _bottomMove;
    [Tooltip("�ʍs�l�|�W�V����")] Transform _walkerPositon;
    [Tooltip("�O��ړ�����X���W")] float _oldX;
    Vector2 _walkerScale;
    [SerializeField, Header("���s�X�s�[�h")] float _walkerSpeed;
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
        //�O���X���W����ǂ���ɓ��������Ō���������
        _walkerScale = this.transform.localScale;
        if (_walkerPositon.position.x <= _oldX && 1 == _walkerScale.x)   //���Ɉړ� ���� ���݃X�v���C�g���E������������A�������ɕύX
        {
            _walkerScale.x = -1;
        }
        else if (_walkerPositon.position.x > _oldX && _walkerScale.x == -1)   //�E�Ɉړ� ���� ���݃X�v���C�g����������������A�E�����ɕύX
        {
            {
                _walkerScale.x = 1;
            }
        }
        else
        {
            return;
        }

        //�ʍs�l�̈ړ������˕Ԃ菈��
        if (_moveDirection.x == _walkerPositon.position.x && _moveDirection.y == _walkerPositon.position.y)  //player�I�u�W�F�N�g���ړI�n�ɓ��B����ƁA
        {
            _moveDirection = MoveRandomPosition();  //�ړI�n���Đݒ�
        }
        this.transform.position = Vector2.MoveTowards(this.transform.position, _moveDirection, _walkerSpeed * Time.deltaTime);



        _oldX = _walkerPositon.position.x;
    }


    private Vector2 MoveRandomPosition()  // �ړI�n�𐶐��Ax��y�̃|�W�V�����������_���ɒl���擾 
    {
        Vector2 _randomPosi = new Vector2(Random.Range((int)_leftMove, (int)_rightMove), Random.Range((int)_bottomMove, (int)_topMove));
        return _randomPosi;
    }
}
