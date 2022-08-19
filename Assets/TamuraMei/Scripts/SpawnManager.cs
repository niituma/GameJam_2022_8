using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>�^�X�N�ƒʍs�l���X�|�[��������</summary>
public class SpawnManager : MonoBehaviour
{
    [Tooltip("�X�|�[���������")] float _spawnTime;
    [SerializeField] int _spawnTimeMin;
    [SerializeField] int _spawnTimeMax;
    [SerializeField, Tooltip("�X�|�[��������Q�[���I�u�W�F�N�g")] GameObject _spawned;
    TaskBase _taskBase;

    void Start()
    {
        _taskBase = _spawned.GetComponent<TaskBase>();
        _spawnTime = Random.Range(_spawnTimeMin, _spawnTimeMax);
        Debug.Log(_spawnTime);
    }

    void Update()
    {
        _spawnTime -= Time.deltaTime;
        int i = 0;

        //�J�E���g�̐��ɂ���ă��x�����ς���Ă���
        if (_taskBase.Count == 0)
        {
            i = 0;
        }
        else if (_taskBase.Count == 10)
        {
            i = 2;
        }
        else if (_taskBase.Count == 20)
        {
            i = 4;
        }

        if (_spawnTime < i)
        {
            //�X�|�[�������āA���̎��������߂�
            Instantiate(_spawned, this.transform.position, Quaternion.identity);
            _spawnTime = Random.Range(_spawnTimeMin, _spawnTimeMax);
            Debug.Log(_spawnTime);
        }   
    }
}
