using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RescueCat : TaskBase
{
    [SerializeField] bool _help; //��q����

    void Update()
    {
        //�{�^�������ꂽ��_help��true��
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (_help)
        {
            //������O�̏������Ă���N���A
            //�L�Ǝq������낱�ԃA�j���[�V�����H
            Clear();
        }
    }
}
