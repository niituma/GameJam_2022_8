using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanchThief : TaskBase
{
    [SerializeField] bool _panch;

    //�{�^�������ꂽ��_panch��true��

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(_panch)
        {
            //������O�̏������Ă���N���A
            //�|���A�j���[�V�����Ƃ��H
            Clear();
        }
    }
}
