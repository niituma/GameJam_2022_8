using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskBase : MonoBehaviour
{
    [SerializeField] float _limit; //������܂ł̎��� �X�|�[�����������蒷���Ȃ�Ȃ��悤��
    [SerializeField] int _count = 0; //�R���{�p
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

    /// <summary>�^�X�N�N���A�����Ƃ�</summary>
    public void Clear()
    {
        //�J�E���g�A�b�v���ď���
        _scoreScript.PlusScore();
        _count++;
        Destroy(gameObject);
        //score+
    }

    public virtual void Action()
    {
        //Debug.Log("�p����ŃI�[�o�[���C�h���Ă�������");
    }
}
