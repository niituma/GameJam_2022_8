using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>���D���L���b�`</summary>
public class CatchBalloon : TaskBase
{
    [SerializeField] bool _catch;

    // Update is called once per frame
    void Update()
    {
        //�{�^����������_catch��true��
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(_catch)
        {
            //������O�̏������Ă���N���A
            //�q������ԃA�j���[�V�����H
            Clear();
        }
    }
}
