using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskBase : MonoBehaviour
{
    [SerializeField] float _limit; //������܂ł̎���
    [SerializeField] int _count = 0; //�R���{�p
    //bool _clear;
    //public bool Clear { get => _clear; set => _clear = value; }

    protected PlayerController _player;
    void Start()
    {
        _player = FindObjectOfType<PlayerController>();
    }

    public int Count { get => _count; }

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
        //�J�E���g�A�b�v���ď���
        _count++;
        Destroy(gameObject);
        //score+
    }

    public virtual void Action()
    {

    }
}
