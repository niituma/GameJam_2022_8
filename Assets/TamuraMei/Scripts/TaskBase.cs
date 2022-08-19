using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskBase : MonoBehaviour
{
    [SerializeField] float _limit; //������܂ł̎���
    [SerializeField] int _count = 0; //�R���{�p
    protected PlayerController _player;
    protected ScoreScript _score;
    ComboCount _comboCount;

    void Start()
    {
        _comboCount = FindObjectOfType<ComboCount>();
        _player = FindObjectOfType<PlayerController>();
        _score = FindObjectOfType<ScoreScript>();
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
        _score.PlusScore();
        _comboCount.Combo++;
        Destroy(gameObject);
    }

    public virtual void Action()
    {

    }
}
