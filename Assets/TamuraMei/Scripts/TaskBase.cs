using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskBase : MonoBehaviour
{
    [SerializeField] float _limit; //消えるまでの時間 スポーンする周期より長くならないように
    [SerializeField] int _count = 0; //コンボ用
    protected PlayerController _player;
    protected ScoreScript _scoreScript;

    void Start()
    {
        _player = FindObjectOfType<PlayerController>();
        _scoreScript = FindObjectOfType<ScoreScript>();
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
        _scoreScript.PlusScore();
        _count++;
        Destroy(gameObject);
        //score+
    }

    public virtual void Action()
    {
        //Debug.Log("継承先でオーバーライドしてください");
    }
}
