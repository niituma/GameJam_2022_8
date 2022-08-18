using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskBase : MonoBehaviour
{
    [SerializeField] float _limit;
    [SerializeField] int _count; //�R���{�p
    //bool _clear;
    //public bool Clear { get => _clear; set => _clear = value; }

    void Update()
    {
        _limit -= Time.deltaTime;

        if (_limit < 0)
        {
            Destroy(gameObject);
        }
    }

    /// <summary>�^�X�N�N���A�����Ƃ�</summary>
    public void Clear()
    {
        //�����ăJ�E���g�A�b�v
        Destroy(gameObject);
        _count++;
        //score+
    }

    public int Count { get => _count; }
}
