using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>��ʐl���������Ƃ�</summary>
public class PanchPeople : TaskBase
{
    [SerializeField] bool _panch;

    // Update is called once per frame
    void Update()
    {
        //�{�^����������_catch��true��
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (_panch)
        {
            //������O�̏������Ă���N���A
            //�q������ԃA�j���[�V�����H
            Clear();
        }
    }
}
