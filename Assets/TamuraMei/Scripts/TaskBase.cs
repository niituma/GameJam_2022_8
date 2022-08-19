using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskBase : MonoBehaviour
{
    [SerializeField] float _limit; //消えるまでの時間
    [SerializeField] int _count = 0; //コンボ用
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

    /// <summary>タスククリアしたとき</summary>
    public void Clear()
    {
        //カウントアップして消す
        _count++;
        Destroy(gameObject);
        //score+
    }

    public virtual void Action()
    {

    }
}
