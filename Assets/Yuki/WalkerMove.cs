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
    [Tooltip("�����������͈�")] float _leftMove;
    [Tooltip("�E���������͈�")] float _rightMove;
    [Tooltip("����������͈�")] float _topMove;
    [Tooltip("�����������͈�")] float _bottomMove;
    [Tooltip("�ʍs�l�|�W�V����")] Transform _walkerPositon;
    [Tooltip("�O��ړ�����X���W")] float _oldX;
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
        //�ʍs�l�̈ړ������˕Ԃ菈��
        



        //�O���X���W����ǂ���ɓ��������Ō���������
        _walkerScale = transform.localScale;
        if (_walkerPositon.position.x < _oldX && 0 <= _walkerScale.x)   //���Ɉړ� ���� ���݃X�v���C�g���E������������A�������ɕύX
        {
            _walkerScale.x = -1;
        }
        else if (_walkerPositon.position.x > _oldX && _walkerScale.x < 0)   //�E�Ɉړ� ���� ���݃X�v���C�g����������������A�E�����ɕύX
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
